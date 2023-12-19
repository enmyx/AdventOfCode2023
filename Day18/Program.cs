using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sinput = "R 6 (#70c710)\r\nD 5 (#0dc571)\r\nL 2 (#5713f0)\r\nD 2 (#d2c081)\r\nR 2 (#59c680)\r\nD 2 (#411b91)\r\nL 5 (#8ceee2)\r\nU 2 (#caa173)\r\nL 1 (#1b58a2)\r\nU 2 (#caa171)\r\nR 2 (#7807d2)\r\nU 3 (#a77fa3)\r\nL 2 (#015232)\r\nU 2 (#7a21e3)";
            var input = "L 7 (#1dc5f0)\r\nU 6 (#4497e3)\r\nL 3 (#3b21c0)\r\nU 3 (#3d8523)\r\nL 9 (#58e7b2)\r\nU 8 (#35d213)\r\nL 10 (#329390)\r\nD 3 (#1302b3)\r\nR 7 (#07f802)\r\nD 8 (#38fbd3)\r\nL 7 (#6d0e72)\r\nD 6 (#2c2493)\r\nL 5 (#38b7d0)\r\nU 6 (#2ab7b3)\r\nL 2 (#0ce560)\r\nU 6 (#2ab7b1)\r\nL 2 (#2f6940)\r\nU 2 (#2a5a83)\r\nL 3 (#477150)\r\nD 11 (#0baea3)\r\nL 4 (#3899c0)\r\nD 3 (#34a803)\r\nL 5 (#55c0d0)\r\nU 9 (#328483)\r\nL 2 (#460290)\r\nU 5 (#48cfd3)\r\nL 4 (#1e3150)\r\nU 5 (#3b7ea3)\r\nL 7 (#2c0a10)\r\nU 11 (#51d803)\r\nL 4 (#39fe80)\r\nU 3 (#51d801)\r\nR 10 (#2938e0)\r\nU 2 (#1c17f3)\r\nR 4 (#0df9a0)\r\nU 3 (#579691)\r\nL 8 (#354a50)\r\nU 4 (#3d0131)\r\nL 6 (#1029b0)\r\nU 7 (#0c19b3)\r\nL 3 (#5f48c0)\r\nU 2 (#0c19b1)\r\nL 4 (#15ff10)\r\nD 9 (#0f08b1)\r\nL 5 (#1c8160)\r\nU 9 (#573b71)\r\nL 6 (#2d58e0)\r\nU 3 (#479121)\r\nL 4 (#1c7bb0)\r\nU 8 (#34d583)\r\nL 10 (#416f10)\r\nD 5 (#34d581)\r\nL 7 (#59af90)\r\nU 5 (#24a821)\r\nL 9 (#196ca2)\r\nU 6 (#1f89d3)\r\nL 4 (#6b4812)\r\nU 2 (#1f89d1)\r\nL 6 (#32e5a2)\r\nU 8 (#5eb4c1)\r\nR 7 (#5bffe0)\r\nU 10 (#3f8051)\r\nR 8 (#29ac30)\r\nU 4 (#495a21)\r\nR 7 (#3b4e10)\r\nU 2 (#52d3a1)\r\nR 7 (#1e27d0)\r\nU 4 (#09ad83)\r\nR 8 (#385530)\r\nU 4 (#218943)\r\nR 3 (#0d8de0)\r\nU 3 (#218941)\r\nR 3 (#3ac220)\r\nU 12 (#09ad81)\r\nR 3 (#08aa80)\r\nU 5 (#33c7b3)\r\nR 2 (#37a350)\r\nU 3 (#6808c3)\r\nR 11 (#355310)\r\nU 3 (#6808c1)\r\nR 3 (#14fbe0)\r\nU 6 (#47b293)\r\nR 6 (#28ab80)\r\nU 3 (#37d873)\r\nR 4 (#607702)\r\nU 2 (#3d77a3)\r\nR 4 (#18a432)\r\nU 3 (#26ee23)\r\nR 10 (#0ba7e0)\r\nU 3 (#0b2863)\r\nR 7 (#604a60)\r\nU 7 (#477053)\r\nR 2 (#0a1210)\r\nU 4 (#2f7e63)\r\nR 9 (#0316e0)\r\nD 5 (#1372d3)\r\nR 10 (#382a30)\r\nD 3 (#2da293)\r\nR 3 (#100920)\r\nD 7 (#5267e3)\r\nR 2 (#66c240)\r\nD 4 (#1c94a3)\r\nL 5 (#2d7770)\r\nU 5 (#2c0061)\r\nL 7 (#4181c2)\r\nD 5 (#1f97c1)\r\nL 3 (#4181c0)\r\nD 4 (#2b79b1)\r\nR 9 (#1bcaf0)\r\nD 4 (#04de93)\r\nR 2 (#010a22)\r\nD 4 (#599823)\r\nR 3 (#010a20)\r\nU 6 (#189b23)\r\nR 4 (#38f770)\r\nU 9 (#452e51)\r\nR 3 (#2551f0)\r\nU 6 (#333c81)\r\nR 6 (#0554d0)\r\nU 5 (#411e13)\r\nL 4 (#487840)\r\nU 10 (#411e11)\r\nR 4 (#2c69e0)\r\nU 7 (#13c311)\r\nL 6 (#164330)\r\nU 4 (#7449a1)\r\nR 10 (#467570)\r\nU 5 (#47fcc1)\r\nR 2 (#13e090)\r\nU 5 (#2e45a3)\r\nR 4 (#0f97a0)\r\nU 9 (#129b03)\r\nR 3 (#46c520)\r\nD 9 (#11dcf3)\r\nR 4 (#0d0e42)\r\nD 4 (#05ca31)\r\nR 4 (#56d742)\r\nD 2 (#05ca33)\r\nR 6 (#1e5ae2)\r\nD 3 (#56bbb3)\r\nR 9 (#1ce6b2)\r\nD 5 (#039d83)\r\nR 2 (#3f1c90)\r\nD 4 (#198063)\r\nL 11 (#3cf8a0)\r\nD 7 (#198061)\r\nL 3 (#2311e0)\r\nD 4 (#401ab3)\r\nL 7 (#46c522)\r\nD 5 (#2d4703)\r\nR 6 (#0f97a2)\r\nD 7 (#053643)\r\nR 6 (#603110)\r\nD 12 (#2ab333)\r\nR 2 (#25d970)\r\nD 3 (#1956d3)\r\nR 5 (#528eb0)\r\nD 2 (#3a55e3)\r\nR 5 (#1aa8d0)\r\nU 5 (#29e981)\r\nL 5 (#133d80)\r\nU 8 (#559581)\r\nR 5 (#133d82)\r\nU 4 (#298e61)\r\nR 3 (#0ed762)\r\nD 5 (#481221)\r\nR 4 (#0ed760)\r\nD 9 (#3a5a61)\r\nR 4 (#265580)\r\nD 3 (#241031)\r\nR 3 (#2bacb0)\r\nD 10 (#4e8481)\r\nR 4 (#4f2bc0)\r\nD 10 (#47fcc3)\r\nL 3 (#15d6f0)\r\nD 9 (#6a0e71)\r\nL 5 (#3cc390)\r\nD 4 (#2fa353)\r\nL 4 (#272140)\r\nU 5 (#029653)\r\nL 3 (#428820)\r\nU 8 (#23f923)\r\nL 4 (#036c82)\r\nD 4 (#3315f3)\r\nL 7 (#663ce2)\r\nD 2 (#09be53)\r\nL 8 (#075c00)\r\nD 5 (#552f63)\r\nL 5 (#662630)\r\nD 2 (#3e3fb1)\r\nL 9 (#543310)\r\nD 5 (#2b6db3)\r\nR 8 (#06d960)\r\nD 2 (#2b6db1)\r\nR 3 (#570160)\r\nD 6 (#441a91)\r\nR 6 (#2f24e2)\r\nD 11 (#2ca451)\r\nR 7 (#5700c0)\r\nD 5 (#36e6f1)\r\nR 3 (#5700c2)\r\nD 8 (#374141)\r\nR 5 (#2b1072)\r\nU 11 (#489e23)\r\nR 5 (#456682)\r\nD 4 (#522e63)\r\nR 3 (#127202)\r\nD 7 (#65dc21)\r\nR 8 (#489d40)\r\nD 3 (#686b21)\r\nL 4 (#107ca2)\r\nD 7 (#2271a3)\r\nR 4 (#148da2)\r\nD 3 (#34bf71)\r\nR 2 (#70b522)\r\nD 9 (#34bf73)\r\nR 8 (#49a172)\r\nD 6 (#2271a1)\r\nR 3 (#138232)\r\nU 4 (#3e4511)\r\nR 4 (#0bb2b0)\r\nU 8 (#2958d1)\r\nR 5 (#1df330)\r\nU 3 (#23af43)\r\nL 5 (#4bbaa0)\r\nU 7 (#23af41)\r\nL 4 (#125270)\r\nU 9 (#41ec91)\r\nR 2 (#222ff0)\r\nU 5 (#2936d1)\r\nR 8 (#2e2310)\r\nD 5 (#2e05a1)\r\nR 3 (#0ae0c0)\r\nD 11 (#074021)\r\nR 7 (#52f6e0)\r\nU 2 (#074023)\r\nR 3 (#590720)\r\nU 6 (#469f01)\r\nR 3 (#34f792)\r\nU 7 (#002dd1)\r\nR 4 (#409522)\r\nD 3 (#002dd3)\r\nR 6 (#149f72)\r\nD 5 (#1cc8f1)\r\nR 5 (#095222)\r\nD 7 (#3eab71)\r\nR 3 (#236082)\r\nD 11 (#3b3d71)\r\nR 2 (#6e2530)\r\nD 3 (#0887f1)\r\nL 6 (#1795d0)\r\nU 7 (#21f2d3)\r\nL 6 (#194240)\r\nD 7 (#2e0d03)\r\nL 3 (#605a50)\r\nD 4 (#257243)\r\nL 8 (#0a5380)\r\nD 7 (#2b70c3)\r\nL 4 (#428fd0)\r\nD 8 (#5b1513)\r\nL 6 (#1bf3f0)\r\nD 3 (#341241)\r\nL 3 (#1f7ea0)\r\nD 8 (#2eda01)\r\nR 6 (#527980)\r\nD 7 (#62ec43)\r\nR 10 (#156e00)\r\nD 5 (#53ce33)\r\nR 4 (#3a5f20)\r\nD 3 (#2f3bb3)\r\nR 6 (#5dacd0)\r\nU 4 (#47f0e1)\r\nR 6 (#538c70)\r\nU 4 (#32a283)\r\nR 8 (#27c140)\r\nD 9 (#198283)\r\nR 6 (#1b5ba0)\r\nU 9 (#15de53)\r\nR 4 (#037d60)\r\nU 7 (#373ac3)\r\nR 7 (#282640)\r\nU 7 (#33c993)\r\nR 6 (#2f6bc0)\r\nU 4 (#236a23)\r\nR 5 (#4977b0)\r\nD 4 (#076301)\r\nR 6 (#56dc60)\r\nU 3 (#30afb1)\r\nR 2 (#720272)\r\nU 8 (#2b0fc1)\r\nR 7 (#19ac60)\r\nU 7 (#07ff61)\r\nR 3 (#585610)\r\nU 2 (#4969b1)\r\nR 7 (#56dc62)\r\nU 5 (#029821)\r\nR 9 (#60a4e0)\r\nU 8 (#1688a3)\r\nL 4 (#19a5b0)\r\nU 3 (#20db03)\r\nL 7 (#1a7950)\r\nU 6 (#1ab903)\r\nL 8 (#463660)\r\nU 2 (#449963)\r\nL 3 (#11ec80)\r\nD 4 (#206da3)\r\nL 8 (#1057b0)\r\nD 6 (#17ffa1)\r\nL 8 (#6cda70)\r\nD 4 (#26df51)\r\nL 3 (#001d70)\r\nU 9 (#3e42f1)\r\nL 5 (#55e962)\r\nU 5 (#138341)\r\nL 6 (#0c3e52)\r\nU 9 (#4ae8f1)\r\nR 8 (#0ad032)\r\nU 7 (#14e3b1)\r\nR 4 (#5a3b70)\r\nD 7 (#1dad81)\r\nR 11 (#3d8e92)\r\nU 6 (#441b61)\r\nL 6 (#20de92)\r\nU 10 (#55efb1)\r\nL 6 (#1d72c2)\r\nU 10 (#1469a1)\r\nL 6 (#21f4b0)\r\nU 4 (#49b921)\r\nL 2 (#560f10)\r\nU 10 (#49b923)\r\nL 3 (#03dc20)\r\nD 6 (#249e01)\r\nL 7 (#6859d0)\r\nD 4 (#0947e1)\r\nL 3 (#5d3fd2)\r\nD 11 (#2c3801)\r\nL 6 (#26cab2)\r\nD 4 (#1f5b51)\r\nR 13 (#0fcc92)\r\nD 3 (#638131)\r\nL 7 (#404362)\r\nD 2 (#6cc863)\r\nL 6 (#1d8d62)\r\nD 4 (#161423)\r\nL 6 (#595612)\r\nU 7 (#09d071)\r\nL 4 (#10a5d0)\r\nU 4 (#633011)\r\nL 8 (#3cddf0)\r\nU 3 (#3a8471)\r\nL 7 (#407050)\r\nU 7 (#00b9a1)\r\nL 3 (#2537e0)\r\nU 2 (#00b9a3)\r\nL 5 (#3a9220)\r\nU 5 (#212a31)\r\nL 7 (#572a62)\r\nU 5 (#0b0ea3)\r\nL 4 (#52f702)\r\nU 6 (#0b0ea1)\r\nR 6 (#077262)\r\nU 9 (#116db1)\r\nR 7 (#688352)\r\nU 8 (#37c5e3)\r\nR 7 (#23b522)\r\nU 3 (#37c5e1)\r\nR 6 (#4a4aa2)\r\nU 9 (#57bf21)\r\nR 4 (#60ae60)\r\nU 3 (#06dc81)\r\nR 3 (#47d900)\r\nD 4 (#587561)\r\nR 6 (#2940e0)\r\nD 8 (#1268d1)\r\nR 5 (#0ec482)\r\nD 6 (#38b6c1)\r\nR 6 (#59c532)\r\nD 8 (#2e4421)\r\nR 6 (#0b8022)\r\nU 5 (#410a61)\r\nR 2 (#7409d0)\r\nU 6 (#28e351)\r\nR 8 (#15d2e0)\r\nD 4 (#12ab01)\r\nR 5 (#100f80)\r\nD 6 (#44c953)\r\nR 4 (#33eef0)\r\nU 6 (#23c7d3)\r\nR 5 (#4696e0)\r\nU 4 (#222123)\r\nR 9 (#26d070)\r\nU 9 (#4cec13)\r\nR 2 (#560af2)\r\nU 6 (#5099a3)\r\nL 11 (#4b4b52)\r\nU 4 (#10b4e3)\r\nL 8 (#40e6b0)\r\nU 6 (#1c6173)\r\nL 5 (#2e31e0)\r\nD 6 (#3d8c01)\r\nL 7 (#1cc6f0)\r\nU 9 (#083731)\r\nL 4 (#463da0)\r\nU 8 (#1cb711)\r\nR 8 (#0b4110)\r\nU 8 (#2252b3)\r\nR 10 (#60b900)\r\nU 7 (#2252b1)\r\nR 8 (#0ce680)\r\nU 5 (#467f81)\r\nR 9 (#0ad0b2)\r\nU 2 (#359203)\r\nR 9 (#67bc02)\r\nU 9 (#359201)\r\nR 4 (#0653e2)\r\nD 3 (#281ca1)\r\nR 9 (#1b8ee0)\r\nD 6 (#0b3861)\r\nL 8 (#336f02)\r\nD 3 (#3201f1)\r\nL 4 (#4a85a2)\r\nD 7 (#111eb1)\r\nL 9 (#1c9c90)\r\nD 7 (#145011)\r\nL 11 (#083be0)\r\nD 2 (#516321)\r\nL 6 (#083be2)\r\nD 9 (#20bb21)\r\nR 5 (#3d8030)\r\nD 6 (#404031)\r\nR 8 (#642420)\r\nU 4 (#56cf61)\r\nR 7 (#55c610)\r\nD 4 (#20d1e1)\r\nR 9 (#1b5e10)\r\nD 9 (#1e85d1)\r\nR 9 (#361f10)\r\nD 3 (#3d69f1)\r\nR 9 (#16da12)\r\nD 6 (#2d6471)\r\nR 5 (#5d9642)\r\nD 3 (#4656f1)\r\nR 6 (#44b540)\r\nD 8 (#2b6131)\r\nR 7 (#2ce630)\r\nD 7 (#2b6133)\r\nR 3 (#61b2a0)\r\nD 4 (#4c2661)\r\nR 4 (#3b7372)\r\nD 8 (#01ed73)\r\nR 5 (#4c3962)\r\nD 3 (#01ed71)\r\nR 4 (#4ba142)\r\nU 9 (#4377f1)\r\nR 3 (#1deb32)\r\nU 6 (#3f3323)\r\nR 3 (#22b722)\r\nU 7 (#37bc13)\r\nR 3 (#1918d2)\r\nU 4 (#13c8b3)\r\nR 5 (#1918d0)\r\nD 12 (#3e4d83)\r\nR 3 (#22b720)\r\nD 5 (#0cefe3)\r\nR 5 (#2bf9f2)\r\nD 9 (#3122d3)\r\nR 8 (#41a3e2)\r\nD 10 (#3122d1)\r\nR 8 (#0b6e02)\r\nU 7 (#266641)\r\nL 4 (#5a1cc2)\r\nU 5 (#060d11)\r\nR 4 (#32ff32)\r\nU 7 (#446c91)\r\nR 5 (#319c82)\r\nD 3 (#446c93)\r\nR 7 (#1bf562)\r\nD 2 (#44af13)\r\nR 6 (#6f3132)\r\nD 6 (#312433)\r\nL 5 (#489da0)\r\nD 5 (#53a343)\r\nL 8 (#489da2)\r\nD 3 (#5a6673)\r\nR 7 (#0f0f92)\r\nD 6 (#01b8b3)\r\nL 3 (#3c6b12)\r\nD 5 (#725613)\r\nL 10 (#114b12)\r\nD 4 (#14ace3)\r\nL 8 (#30d292)\r\nD 9 (#1ebac3)\r\nL 6 (#3c4292)\r\nD 7 (#39e2a3)\r\nL 2 (#1f3882)\r\nD 4 (#658381)\r\nL 3 (#0b0252)\r\nD 8 (#699e71)\r\nL 10 (#2b4ae2)\r\nD 2 (#1ac903)\r\nL 5 (#60cef2)\r\nD 4 (#515ea3)\r\nL 5 (#4d3790)\r\nD 6 (#354183)\r\nL 4 (#398170)\r\nU 3 (#7163a3)\r\nL 10 (#398172)\r\nU 7 (#0608f3)\r\nL 8 (#4d3792)\r\nD 4 (#06c7a3)\r\nL 7 (#5819c2)\r\nD 5 (#17c3f1)\r\nL 3 (#0c8892)\r\nD 5 (#67f951)\r\nR 6 (#3ff470)\r\nD 12 (#397601)\r\nR 6 (#3ff472)\r\nD 4 (#4f6451)\r\nL 9 (#665a22)\r\nD 2 (#1705c1)\r\nL 3 (#14df92)\r\nD 7 (#4b40a1)\r\nL 4 (#1fa1f2)\r\nD 5 (#3b7231)\r\nL 10 (#063e12)\r\nD 7 (#2a8fb1)\r\nL 4 (#6b71e2)\r\nU 4 (#218101)\r\nL 4 (#2e2f52)\r\nU 4 (#221411)\r\nL 5 (#200732)\r\nU 5 (#0ac7e1)\r\nL 9 (#50af62)\r\nD 9 (#4b7c81)\r\nL 3 (#50af60)\r\nD 4 (#2b9d31)\r\nL 13 (#4766d2)\r\nD 5 (#25ef21)\r\nR 3 (#119862)\r\nD 2 (#517a31)\r\nR 4 (#3e6072)\r\nD 10 (#21cfa1)\r\nR 6 (#4437f2)\r\nU 12 (#30f031)\r\nR 4 (#036652)\r\nD 7 (#453c91)\r\nR 5 (#05ea22)\r\nD 10 (#2da1e1)\r\nR 2 (#4da5a2)\r\nD 2 (#2da1e3)\r\nR 6 (#2bffc2)\r\nD 9 (#453c93)\r\nR 9 (#4ed2d2)\r\nD 3 (#141b71)\r\nR 9 (#3ecad2)\r\nD 5 (#234873)\r\nL 11 (#3c4982)\r\nD 3 (#2ed113)\r\nL 7 (#3c4980)\r\nD 7 (#4a6553)\r\nL 8 (#49bf02)\r\nD 8 (#337011)\r\nL 9 (#2eb772)\r\nD 3 (#690ec1)\r\nL 2 (#25f0a2)\r\nD 7 (#62eeb3)\r\nL 6 (#1ae012)\r\nD 7 (#34e643)\r\nR 6 (#382a72)\r\nD 7 (#281183)\r\nL 11 (#271932)\r\nD 4 (#470d23)\r\nL 9 (#4ca812)\r\nD 4 (#6f1ea1)\r\nL 7 (#4702f2)\r\nD 8 (#34e641)\r\nL 4 (#155c42)\r\nD 10 (#62eeb1)\r\nL 7 (#3a2422)\r\nD 4 (#3f7ca3)\r\nL 9 (#39b860)\r\nU 4 (#5cf1c3)\r\nL 13 (#39b862)\r\nU 4 (#4751f3)\r\nL 4 (#322dd2)\r\nU 4 (#539531)\r\nL 5 (#4171a2)\r\nU 5 (#539533)\r\nR 9 (#075042)\r\nD 5 (#1e57d3)\r\nR 7 (#5cc952)\r\nU 5 (#0ac0d3)\r\nR 6 (#1af522)\r\nU 9 (#374273)\r\nL 4 (#2992f2)\r\nU 2 (#299893)\r\nL 4 (#267bc2)\r\nU 10 (#47af63)\r\nL 3 (#282402)\r\nU 4 (#06a063)\r\nL 5 (#5cce72)\r\nU 9 (#47fba3)\r\nL 3 (#1168e2)\r\nU 10 (#3b1071)\r\nL 4 (#178c22)\r\nU 3 (#42b971)\r\nL 5 (#178c20)\r\nU 8 (#1dca41)\r\nR 9 (#442912)\r\nU 8 (#5b9241)\r\nL 3 (#1da682)\r\nU 7 (#31ff23)\r\nL 10 (#3cd732)\r\nU 5 (#33bab3)\r\nL 5 (#159fb2)\r\nU 4 (#2e5d93)\r\nL 7 (#5f9702)\r\nU 4 (#5566e3)\r\nL 4 (#0ba292)\r\nU 8 (#07f963)\r\nL 3 (#410a02)\r\nU 3 (#6ace93)\r\nL 5 (#0913a2)\r\nU 2 (#21a553)\r\nL 10 (#3d71a2)\r\nD 6 (#25ff63)\r\nL 5 (#5285b2)\r\nD 8 (#3cfc73)\r\nL 3 (#13aba2)\r\nD 7 (#24a793)\r\nL 4 (#29e4c2)\r\nD 12 (#1dc4b3)\r\nL 5 (#3cb102)\r\nD 8 (#5b8433)\r\nL 5 (#3cb100)\r\nD 7 (#22d9f3)\r\nL 7 (#6db9c2)\r\nD 6 (#4cd683)\r\nL 6 (#083f42)\r\nU 11 (#09bbc3)\r\nL 5 (#609002)\r\nD 7 (#12b603)\r\nL 7 (#041be2)\r\nD 8 (#4f3823)\r\nL 5 (#5a3412)\r\nU 7 (#14de13)\r\nL 6 (#036ee2)\r\nU 5 (#442823)\r\nL 7 (#6c5502)\r\nU 3 (#2edcc3)\r\nL 9 (#3b6b72)\r\nU 8 (#321e73)\r\nR 7 (#48e5a2)\r\nU 6 (#2fbec3)\r\nL 12 (#44ed12)\r\nU 6 (#0c1893)\r\nR 12 (#61a8e0)\r\nU 4 (#073043)\r\nR 4 (#0d47c0)\r\nD 6 (#469b63)\r\nR 2 (#047ae0)\r\nD 10 (#39b7d3)\r\nR 3 (#2492d0)\r\nU 8 (#2026f3)\r\nR 3 (#73fb40)\r\nU 2 (#201333)\r\nR 3 (#372f72)\r\nU 2 (#2c6143)\r\nR 10 (#615ea2)\r\nU 4 (#355653)\r\nR 7 (#3876d2)\r\nU 9 (#080463)\r\nL 8 (#3af4b2)\r\nU 10 (#6840e3)\r\nL 3 (#5472d2)\r\nU 9 (#005683)";

            var lines = input.Replace("\r\n", "\n").Split('\n').ToList();

            var digs = new List<(long x, long y)>();
            long x = 0;
            long y = 0;
            long minX = 0;
            long minY = 0;
            long maxX = 0;
            long maxY = 0;
            digs.Add((x, y));

            long perimeter = 0;
            foreach (var line in lines)
            {
                //ParsePart1(digs, ref x, ref y, line);
                perimeter += ParsePart2(digs, ref x, ref y, line);


                minX = Math.Min(minX, x);
                minY = Math.Min(minY, y);
                maxX = Math.Max(maxX, x);
                maxY = Math.Max(maxY, y);
            }

            Console.WriteLine(minX);
            Console.WriteLine(minY);
            Console.WriteLine(maxX);
            Console.WriteLine(maxY);

            //Part1(digs, minX, minY, maxX, maxY);

            long shoelace = digs.Zip(digs.Skip(1), (a, b) => a.x * b.y - b.x * a.y).Sum();
            Console.WriteLine((shoelace + perimeter) / 2 + 1);
        }

        private static void Part1(List<(int x, int y)> digs, int minX, int minY, int maxX, int maxY)
        {
            var map = new char[maxY - minY + 1, maxX - minX + 1];

            foreach (var dig in digs)
                map[dig.y - minY, dig.x - minX] = '#';

            var stack = new Stack<(long x, long y)>();
            stack.Push((1 - minX, 1 - minY));
            Flood(map, stack);

            //Print(map);
            long sum = 0;
            for (int y = 0; y < map.GetLength(0); y++)
                for (int x = 0; x < map.GetLength(1); x++)
                    if (map[y, x] != '\0')
                        sum++;
            Console.WriteLine(sum);
        }

        private static void ParsePart1(List<(long x, long y)> digs, ref long x, ref long y, string line)
        {
            var data = line.Split(' ');
            string direction = data[0];
            for (int i = 0; i < int.Parse(data[1]); i++)
            {
                if (direction == "R")
                    digs.Add((++x, y));
                else if (direction == "D")
                    digs.Add((x, ++y));
                else if (direction == "L")
                    digs.Add((--x, y));
                else if (direction == "U")
                    digs.Add((x, --y));
            }
        }

        private static int ParsePart2(List<(long x, long y)> digs, ref long x, ref long y, string line)
        {
            var data = line.Split('#');
            int direction = int.Parse(data[1].Substring(5, 1));
            int length = int.Parse(data[1].Substring(0, 5), NumberStyles.HexNumber);

            if (direction == 0)
                x += length;
            else if (direction == 1)
                y += length;
            else if (direction == 2)
                x -= length;
            else if (direction == 3)
                y -= length;

            digs.Add((x, y));
            return length;
        }

        private static void Flood(char[,] map, Stack<(long x, long y)> stack)
        {
            while (stack.Any())
            {
                (long x, long y) = stack.Pop();
                if (x < 0 || x >= map.GetLength(1))
                    return;
                if (y < 0 || y >= map.GetLength(0))
                    return;
                if (map[y, x] == '\0')
                {
                    map[y, x] = '-';
                    stack.Push((x + 1, y));
                    stack.Push((x, y + 1));
                    stack.Push((x - 1, y));
                    stack.Push((x, y - 1));
                }
            }
        }

        private static void Print(char[,] map)
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine("out.txt")))
            {
                for (long y = 0; y < map.GetLength(0); y++)
                {
                    var sb = new StringBuilder(map.GetLength(1));
                    for (long x = 0; x < map.GetLength(1); x++)
                        sb.Append(map[y, x] == 0 ? ' ' : map[y, x]);
                    Console.WriteLine(sb.ToString());
                    outputFile.WriteLine(sb.ToString());
                }
            }

            Console.WriteLine();
        }
    }
}
