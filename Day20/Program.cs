using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sinput = "broadcaster -> a, b, c\r\n%a -> b\r\n%b -> c\r\n%c -> inv\r\n&inv -> a";
            var dinput = "broadcaster -> a\r\n%a -> inv, con\r\n&inv -> b\r\n%b -> con\r\n&con -> output";
            var input = "%jb -> fz\r\n%xz -> ck, bg\r\n%xm -> qt, cs\r\n%df -> hc, lq\r\n%mt -> sx\r\n%fr -> ks, hc\r\n%tn -> pf\r\n%gt -> pp, kb\r\n%jn -> ck, nz\r\n%td -> kz\r\n&rd -> vd\r\n%pp -> gv, kb\r\n&qt -> jb, vx, bt, gh, td, gb\r\n%ms -> xz\r\n%vx -> fp\r\n%rb -> ck, mt\r\n%nz -> hh\r\n%fp -> rp, qt\r\n%gd -> gc\r\n%gv -> kb\r\n%nl -> cc, hc\r\n%cs -> qt\r\n%kz -> jb, qt\r\n%vg -> fr, hc\r\n%zq -> qt, xm\r\n%pv -> ps\r\n&bt -> vd\r\n%ps -> kb, rf\r\n%hh -> ck, ms\r\nbroadcaster -> gn, gb, rb, df\r\n%gh -> td\r\n%rf -> kb, nm\r\n%rp -> qt, gh\r\n%gc -> kb, pv\r\n%gb -> vx, qt\r\n%rq -> ck, ts\r\n%nm -> gt\r\n%gn -> kb, tn\r\n&ck -> nz, fv, rb, sx, ms, mt\r\n&fv -> vd\r\n%cc -> vg\r\n%bg -> ck, rq\r\n&hc -> qr, ch, df, dj, cc, rd\r\n%qr -> dj\r\n%gq -> hc, ch\r\n&pr -> vd\r\n%ks -> lc, hc\r\n%dj -> nl\r\n%fz -> qt, zq\r\n%lq -> gq, hc\r\n&kb -> pv, pr, tn, nm, pf, gn, gd\r\n%ts -> ck\r\n%lc -> hc\r\n%jl -> ck, jn\r\n%sx -> jl\r\n%pf -> gd\r\n&vd -> rx\r\n%ch -> qr";

            var lines = input.Replace("\r\n", "\n").Split('\n').ToList();

            var relays = new Dictionary<string, Relay>();
            relays["button"] = new Broadcaster { Name = "button" };
            foreach (var line in lines)
            {
                var name = line.Split(' ')[0];
                if (name == "broadcaster")
                    relays[name] = new Broadcaster { Name = name };
                else if (name.StartsWith("%"))
                {
                    name = name.Substring(1);
                    relays[name] = new FlipFlop { Name = name };
                }
                else
                {
                    name = name.Substring(1);
                    relays[name] = new Conjunction { Name = name };
                }
            }

            var connections = new Dictionary<Relay, List<Relay>>();
            connections[relays["button"]] = new List<Relay> { relays["broadcaster"] };

            Relay watched = null;
            foreach (var line in lines)
            {
                var name = line.Split(' ')[0];
                if (name != "broadcaster")
                    name = name.Substring(1);
                var outputs = line.Split('>')[1].Split(',');
                var relay = relays[name];
                connections[relay] = new List<Relay>();
                foreach (var output in outputs)
                {
                    string destination = output.Trim();
                    if (!relays.ContainsKey(destination))
                    {
                        relays[destination] = new Output { Name = destination };
                        watched = relay;
                    }

                    Relay next = relays[destination];
                    connections[relay].Add(next);

                    if (next is Conjunction conjunction)
                        conjunction.InputRelays[relay] = Pulse.Low;
                }
            }

            int lows = 0;
            int highs = 0;
            int button = 0;
            bool started = false;
            var watchSource = new HashSet<Relay>();
            var repeats = new List<int>();
            do
            {
                ++button;
                var queue = new Queue<(Relay relay, Relay from, Pulse pulse)>();
                queue.Enqueue((relays["button"], null, Pulse.Low));

                while (queue.Count > 0)
                {
                    var (relay, from, pulse) = queue.Dequeue();
                    pulse = relay.Send(pulse, from);
                    if (pulse != Pulse.None)
                    {
                        foreach (var destination in connections[relay])
                        {
                            //Console.WriteLine($"{relay.Name} -{pulse}-> {destination.Name}");
                            if (pulse == Pulse.Low)
                            {
                                lows++;
                            }
                            else
                            {
                                if (destination == watched)
                                {
                                    Console.WriteLine($"b:{button} from:{relay.Name}");
                                    if (watchSource.Contains(relay))
                                    {
                                        long push = 1;
                                        for (int i = 0; i < repeats.Count; i++)
                                            push = Lcm(push, repeats[i]);
                                        Console.WriteLine(push);   
                                        started = true;
                                    }
                                    watchSource.Add(relay);
                                    repeats.Add(button);
                                }
                                highs++;
                            }

                            queue.Enqueue((destination, relay, pulse));
                        }
                    }
                }
                //Console.WriteLine($"btn {button} h:{highs} l:{lows}");
                //Console.WriteLine();
            //} while (/*relays.Values.Any(r => !r.IsDefault) && */button < 1000);
            } while (!started);
            //Console.WriteLine(lows * highs);
        }

        static long Gcf(long a, long b)
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static long Lcm(long a, long b) => (a / Gcf(a, b)) * b;
    }

    abstract class Relay
    {
        public string Name { get; set; }
        public abstract Pulse Send(Pulse impulse, Relay from);
    }

    class Broadcaster : Relay
    {
        public override Pulse Send(Pulse impulse, Relay from) => impulse;
    }

    class Conjunction : Relay
    {
        public readonly Dictionary<Relay, Pulse> InputRelays = new Dictionary<Relay, Pulse>();

        public override Pulse Send(Pulse impulse, Relay from)
        {
            InputRelays[from] = impulse;
            if (InputRelays.Values.All(p => p == Pulse.High))
                return Pulse.Low;
            return Pulse.High;
        }
    }

    class FlipFlop : Relay
    {
        private bool State { get; set; }

        public override Pulse Send(Pulse impulse, Relay from)
        {
            if (impulse == Pulse.Low)
            {
                State = !State;
                return State ? Pulse.High : Pulse.Low;
            }
            return Pulse.None;
        }
    }

    class Output : Relay
    {
        public override Pulse Send(Pulse impulse, Relay from) => Pulse.None;
    }

    enum Pulse
    {
        None, Low, High
    }
}
