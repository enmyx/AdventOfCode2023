using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sinput = "px{a<2006:qkq,m>2090:A,rfg}\r\npv{a>1716:R,A}\r\nlnx{m>1548:A,A}\r\nrfg{s<537:gd,x>2440:R,A}\r\nqs{s>3448:A,lnx}\r\nqkq{x<1416:A,crn}\r\ncrn{x>2662:A,R}\r\nin{s<1351:px,qqz}\r\nqqz{s>2770:qs,m<1801:hdj,R}\r\ngd{a>3333:R,R}\r\nhdj{m>838:A,pv}\r\n\r\n{x=787,m=2655,a=1222,s=2876}\r\n{x=1679,m=44,a=2067,s=496}\r\n{x=2036,m=264,a=79,s=2244}\r\n{x=2461,m=1339,a=466,s=291}\r\n{x=2127,m=1623,a=2188,s=1013}";
            var input = "hfm{a<1891:R,m<2881:A,m<2987:A,R}\r\nns{s>2289:R,x<3094:A,R}\r\nvll{s<2397:R,x>1015:A,A}\r\nfx{a>3383:R,a>3059:A,A}\r\nbhg{x>669:A,x<605:R,a>3407:R,A}\r\nfr{m>2523:A,m>2353:R,x>2678:dts,A}\r\nllj{m<2149:vzl,pjq}\r\nqh{s<2205:R,R}\r\nnml{a>1072:R,x>1129:R,A}\r\ntb{m<2429:A,m<2506:A,x>2910:R,R}\r\ncr{x<735:R,a<2972:R,x<973:R,R}\r\nrb{s>2603:A,x>240:R,s>2405:A,A}\r\nxr{x>975:A,R}\r\npb{a>2460:A,s>686:A,cq}\r\ndfv{x>1219:A,km}\r\nkc{m>1600:nsj,tjp}\r\nlx{s>3383:kgn,qrh}\r\ndc{s<723:A,x>2900:R,x>2607:A,A}\r\ngxn{s<3351:R,s<3754:A,A}\r\nkkk{a>1099:R,R}\r\njbz{x>3246:R,m<3301:lh,zz}\r\nqf{s<3162:R,m>2686:R,R}\r\ngqb{s>2575:A,m>2634:R,R}\r\npz{a>2415:sv,x<1649:A,a<1508:bv,R}\r\nfn{m<2045:ht,a<1532:sm,x>1630:bxs,gfk}\r\nbr{m>631:A,m>392:A,R}\r\ndtx{a<3420:A,x<582:A,R}\r\nms{m<1784:R,a<1945:R,x<276:R,A}\r\nljm{a<3677:R,m<2840:R,a>3790:R,A}\r\ngcp{x<964:zqt,a>3632:qr,cvc}\r\nkz{m>2543:A,m<2302:R,ns}\r\ngqp{a>1014:A,R}\r\nhq{a>416:kz,m>2537:mm,pt}\r\nbcb{m<2838:A,x>355:R,R}\r\ncp{s>2863:A,R}\r\ngfr{s>2813:vxb,R}\r\nkx{s>3076:A,s>2788:bcb,rb}\r\nlrf{m>3285:jg,a<1934:A,R}\r\nsjf{x>2162:dc,s>886:ddk,s>327:qjs,zqv}\r\ncqp{a<3274:R,a<3562:pjn,A}\r\nzkb{x>927:vpm,x>553:pbm,pvv}\r\ncl{s<2019:A,a<672:mx,hh}\r\nvxm{s>3645:A,x<3010:R,R}\r\ntl{m>2863:hfq,s<618:xmd,zf}\r\nlc{m<1255:qjt,m<1360:mml,m<1405:rrz,R}\r\nmk{m<2694:A,m<2720:A,m<2742:R,R}\r\nvhd{a<1005:R,a<1032:fl,m>3001:hp,vc}\r\nbhl{a<63:A,A}\r\ndnp{m>2478:R,js}\r\nvx{x>459:A,s>3010:R,A}\r\nmgm{a>2427:A,m<512:A,m<672:R,A}\r\nmkg{m<3037:kqc,pg}\r\npgn{x<657:dbf,bp}\r\ngk{a<2387:A,m>3634:tjf,xrs}\r\nbk{x<1464:R,m<2385:R,s<2889:A,R}\r\nbrh{x<592:A,a>1420:A,a>1294:A,A}\r\njlk{x>3037:A,R}\r\nsj{x>1055:R,A}\r\nhpg{a>2950:R,s<183:R,R}\r\nrvj{s>535:fv,x<2858:kjp,m<1563:hv,ff}\r\nnxz{m>2313:R,s<3765:A,a>2157:A,A}\r\ngml{x>3077:hk,fr}\r\nmnn{a>363:R,A}\r\nrh{a>120:A,a<63:R,a<86:A,A}\r\nkqs{m<1616:xpt,zzs}\r\npp{s>2657:nk,m<2894:hhh,clh}\r\ntnr{m>2934:A,x>1403:A,x<1189:R,A}\r\nkk{x>2090:zkj,m<2508:A,m>2704:A,qln}\r\nzl{a>239:xgn,x<2628:nn,a>99:A,bhl}\r\nlm{a<2364:R,a>3061:A,a<2725:A,A}\r\nmml{s<927:A,A}\r\npn{a<66:R,s>3144:R,x>3414:A,R}\r\ngrp{a>988:gfr,knm}\r\nrbq{a<1659:R,m>2412:R,a>1755:R,R}\r\nbs{x<455:R,m<2320:R,a<1359:A,R}\r\nkh{m<354:A,pcg}\r\nxc{a<915:A,x>481:A,m>1053:R,R}\r\nzm{x<921:A,x<994:A,a<1883:R,A}\r\nxmd{a<1534:vg,m>2299:rpl,xs}\r\ndpj{a>155:A,s<3370:lf,s<3618:nxx,R}\r\njzt{x<2429:R,R}\r\nbgg{a<224:A,m<2159:R,A}\r\ngcg{x<467:A,drb}\r\nsmm{s<3438:rdk,m<1941:A,a<2090:A,shf}\r\nfds{m<817:A,A}\r\ndts{m<2173:A,x<2824:R,A}\r\nnch{a<862:R,A}\r\npkx{x>1081:A,R}\r\nkl{a>3653:A,A}\r\nzmn{a<3055:A,A}\r\nvpm{s>2871:gb,a>302:A,x<1117:qh,A}\r\nzjh{s<681:R,s>1108:A,a>2949:R,A}\r\ncsf{x<2624:A,R}\r\nfqm{a<2452:A,R}\r\nfp{m<2297:R,x<1623:A,m<2552:tb,lgz}\r\nqjs{x>1439:A,m>195:R,A}\r\ntcp{a>3014:dbd,a<2122:xr,s>395:R,qpp}\r\nqlq{m<2703:A,s<1679:R,a<3363:R,A}\r\nqp{s>3440:bmb,s>3155:jxr,m>2536:trb,gtv}\r\npgt{x>2227:R,x<1942:R,m<2848:A,R}\r\nks{a>2805:A,a>2754:A,A}\r\ngzs{a<1925:mg,A}\r\nnn{m<3249:R,x<2147:R,m>3368:A,R}\r\nhv{a<2412:fkv,hpg}\r\nsf{s<3613:A,s<3794:R,a>2553:A,R}\r\ndx{a>2210:kvd,lz}\r\nrt{x<702:sq,a<2430:dp,jd}\r\ntdx{a>951:R,R}\r\nrdk{m>1912:R,s<3160:A,s<3318:A,R}\r\nxd{a>1917:A,a<1756:cgg,s<1553:R,R}\r\nxgn{x<2590:A,A}\r\nmm{m>2703:R,gqb}\r\nkg{x>575:A,s<2499:A,s>2683:R,R}\r\nml{a>1963:R,R}\r\nnt{x<1093:bfn,dr}\r\nkxz{s<2359:qxx,bkc}\r\nqqz{m<1860:A,a<3554:A,s<937:R,R}\r\nzc{s>2080:R,m<2808:qlq,s<1761:bl,lb}\r\ntvf{s>2113:A,a<3780:R,R}\r\ndhh{a<2922:A,a>3078:A,A}\r\ngtv{a>2013:A,m>2316:R,s<3022:R,mc}\r\nxh{x>2824:R,A}\r\nmq{s>2361:thg,sgb}\r\nlf{s>3091:R,A}\r\nlz{a>1814:spd,x<958:jj,kkj}\r\nth{s<215:A,x<3295:R,m>3355:A,A}\r\nxtp{s<2152:A,R}\r\ngqm{m<1316:R,R}\r\ndr{x>2043:A,m>2796:A,s>782:A,R}\r\ndbf{x<616:A,s<2980:R,A}\r\nhhh{x>2202:jzt,R}\r\nsq{a>2651:qcp,s>2270:kx,a<2082:bqv,sh}\r\nsh{x<322:lnq,txg}\r\ntc{x>1958:hr,rkl}\r\nhkm{m<2693:A,m>2768:kv,R}\r\nvjh{m>3433:nqx,a>372:qxl,s>2941:dpj,zl}\r\nnb{m>1186:A,m<1106:R,R}\r\nttg{a<1907:R,R}\r\nrzt{x>1028:R,x<934:A,s<1494:R,A}\r\ngcj{m>493:A,A}\r\nmj{m>759:xc,a<926:A,A}\r\nrp{x>1430:llz,a>3405:R,s>253:cr,xzt}\r\nngj{a<1849:jkc,vcl}\r\nddk{x>1064:A,a>860:A,s>1170:A,R}\r\nfs{m<3638:zv,m>3842:R,s>1558:fh,xg}\r\nrpl{s>314:szc,a<2372:pkk,s<158:gsj,rp}\r\njpb{s<2898:zh,pdq}\r\nngr{a>1086:A,m<1535:A,R}\r\nlsm{m>2766:R,A}\r\nvt{a>2734:R,sf}\r\nkfg{m<3340:jnx,s>2974:jhg,jpx}\r\nhbg{a>39:pn,x>3436:rzv,A}\r\npjq{a<3306:R,a<3496:R,A}\r\nfv{a<2261:ltf,qck}\r\nhh{x>2281:R,s<2324:R,A}\r\npv{m<3610:kfg,dnd}\r\nkfm{x<1892:R,A}\r\ngck{x<1059:zm,s<1802:tnr,R}\r\nknz{s>1104:xlt,x>2522:hkm,m<2690:dnp,nt}\r\nzb{a<1282:A,gxn}\r\nqn{a<2568:R,a>3362:A,A}\r\nfhz{m<2469:R,x<1017:A,R}\r\nhl{s<2004:A,m<2517:A,s<2219:gn,R}\r\nhr{x<2819:A,x<3556:R,R}\r\nhs{m>1138:A,m>1099:R,x<1102:A,R}\r\ngm{s>1235:A,x>871:A,R}\r\nsm{x<1462:xmf,m>2947:xjm,sr}\r\nsgn{a>785:A,hgs}\r\nll{s>2311:A,x<941:A,s>1709:A,A}\r\ngr{m<3579:R,m<3743:R,bcr}\r\nhgz{m>1825:R,A}\r\nvcl{x>1884:A,R}\r\nbp{s<2265:R,a<2991:R,m<931:R,R}\r\nvtg{a>589:A,s>611:A,x<1171:R,A}\r\ndrb{x>499:R,x>483:A,R}\r\nkkj{s>2996:prz,s<2115:A,s<2591:rbq,R}\r\nmf{m>1621:xdf,m>1509:R,zpx}\r\nqx{m>2493:A,s<67:R,s>99:R,A}\r\nxj{x>1073:sd,a<2088:ssz,a<2874:mv,fx}\r\nnl{x>1901:vt,dhh}\r\nqxx{s>1740:gk,a<2502:xd,fs}\r\nlh{x>2845:R,x<2721:R,s<1013:R,R}\r\ngn{a<2827:A,x<888:R,R}\r\nssr{x<1329:hcd,a<3869:bk,s>2378:R,fcm}\r\ndjv{a<669:R,s>2282:A,A}\r\nvg{m>2419:xbq,xxp}\r\nhxz{s>1149:R,s<970:R,R}\r\npcg{m<563:A,R}\r\npfz{s>3593:A,s>3372:R,a<1883:A,R}\r\nspt{s>1816:ffb,R}\r\njs{a>3135:R,a>2472:A,R}\r\nqck{m<1565:R,R}\r\nspd{m<2263:R,x>787:A,fbv}\r\ncnh{m<106:vrl,R}\r\ngmg{m<76:A,R}\r\nltf{a<1339:R,A}\r\nssz{x<912:R,s>2404:R,A}\r\nhx{a>2776:A,s>3120:R,a>2575:R,A}\r\nps{m<2121:R,m>2614:lsm,R}\r\nvzl{s>2769:R,A}\r\nqbq{x<1041:R,A}\r\nzn{x>2869:xtp,s>2386:qv,x>2164:vm,gq}\r\nxpt{a<1592:hkg,jrs}\r\nckf{x<2913:A,s<3461:A,qd}\r\nvmr{s<538:R,A}\r\nxjl{s<1931:R,R}\r\nsd{s<2558:R,m>674:R,R}\r\ngzx{s>3734:R,a>2118:A,x<2007:R,R}\r\nvxb{a>1179:A,x>2948:R,R}\r\ngrj{a<986:A,x<3665:A,R}\r\nhz{m<2410:R,a<1473:R,m<2553:A,R}\r\nxfz{m<664:R,A}\r\nqjt{a>2336:A,R}\r\nskl{m<1447:tbm,x<2563:kc,x<3380:rvj,xmk}\r\nrpt{s>3373:kk,a>3465:pmz,qs}\r\ntbm{x>1640:gl,x>940:lc,x>555:dh,ppp}\r\nrkl{s>758:A,s>703:A,A}\r\nkt{a<1525:sjf,m<165:cnh,a<3002:kmt,glm}\r\nrxb{a>1274:A,s>217:R,x<2590:R,R}\r\nbmb{a<1887:qmq,m>2527:gzx,nxz}\r\nlj{m>1658:A,x<1304:R,a<2946:R,R}\r\ndz{m>958:skl,kqg}\r\ncgg{m>3549:A,a<1669:R,a>1715:A,A}\r\nbv{a<517:R,A}\r\npzp{m>1796:A,s>337:R,A}\r\nkjp{x>2667:R,a>2007:jq,x<2619:tf,R}\r\nmmn{a<962:bfg,s<3092:rd,a<1071:vhd,kkk}\r\nqpj{m<474:jx,vrb}\r\nnbd{s<2643:fdz,x<2979:qc,a>109:dg,hbg}\r\ngv{m<1621:A,a<2391:R,s<526:R,A}\r\nbqv{x<397:A,s>1928:R,s>1735:hfm,vb}\r\nbxn{s>3496:A,R}\r\nrd{m<2982:R,a>1048:R,x>688:rs,A}\r\nxs{x>1594:hnv,m>2097:tcp,spr}\r\nhd{x<2832:R,a<1703:A,A}\r\nsgb{x<2756:R,m<3350:R,a>989:A,R}\r\nct{s>268:A,m<1145:R,R}\r\ngfn{x>2445:R,m>3468:A,R}\r\njrs{m>1415:R,s<2989:R,csf}\r\nmx{a<418:A,a<544:A,R}\r\nsz{x<3171:R,A}\r\nxp{x>96:kp,br}\r\nbz{m<2623:zn,x>2581:npm,s<2334:qz,pp}\r\nhsm{a<809:A,m>2928:R,s>2549:R,R}\r\nvm{x<2604:R,s>1820:A,R}\r\njnx{a<2355:R,ll}\r\nffb{a<3297:R,x>1272:R,m>2403:A,A}\r\ndkm{x>1784:A,a<3116:R,A}\r\npjn{s>2661:A,A}\r\nvrb{x>458:rjt,a<2892:bj,xcb}\r\nktc{s<1670:R,zs}\r\ncq{m<1671:A,a<1916:A,A}\r\ntt{s<2036:A,A}\r\nhnv{s<227:A,R}\r\ndjh{m>3475:R,R}\r\nbx{x>3185:R,m<3404:A,gfn}\r\nbh{m>3890:R,a>2742:R,s<2390:R,R}\r\njk{s<2685:nv,a>577:mj,m>532:vjr,gcg}\r\nzdz{m<2908:R,s<3336:A,R}\r\nbl{a<3471:R,m>2937:A,a<3715:R,A}\r\ngxl{s>3244:jcc,m<2779:rfj,npx}\r\ngq{a<2394:A,s<2052:R,x<1953:dkm,R}\r\ncqv{m<3827:jm,hlq}\r\nvrl{x<2650:R,x<3541:A,A}\r\nglm{x>1916:A,a>3599:nhd,ggg}\r\nzlm{x>195:A,R}\r\nmd{x>1309:zdz,ttg}\r\nvpp{x<3122:R,R}\r\nkv{m>2823:R,x<3299:A,R}\r\nfcm{s<1752:R,m<2347:A,A}\r\nhmr{x<549:bh,a>2572:R,R}\r\nnm{x>2081:R,ljm}\r\nshf{x>2947:A,s>3634:A,x>1974:A,A}\r\npt{x>2491:R,x<2085:A,s<3066:mnn,A}\r\nxdf{a<861:A,R}\r\ndbx{x<1876:A,a<1669:R,R}\r\ndp{s>2341:md,s>2015:gzs,s<1618:pqp,gck}\r\nkgn{x<1215:R,A}\r\nlgz{a>1196:A,R}\r\nin{s>1392:fn,vv}\r\nqln{s>3608:R,m>2588:R,a<3582:A,A}\r\ndvf{x>592:A,m<2183:R,x>320:A,A}\r\ndh{a>1930:A,x>739:A,a<1115:rbz,R}\r\nkvg{x<2234:R,A}\r\nqtn{a>1139:A,s<1193:A,A}\r\npc{a>1879:cm,nch}\r\nfcr{m>2273:rdr,zqz}\r\nqcd{a<2274:A,s>2074:R,R}\r\nbcr{x<3112:A,s>600:R,A}\r\nnv{a<903:cx,s<2221:qnm,a>1077:fds,A}\r\nlkf{x<1086:A,R}\r\nqnm{m<806:R,s<1909:R,m<985:R,R}\r\ngb{a<426:A,x<1187:R,s>3618:R,R}\r\nsxt{s>2383:zt,m>218:nf,x<678:gmg,zmn}\r\ntsc{a<2880:bxn,s>3543:bhg,A}\r\nnpx{x<551:R,m<3518:mjv,rkd}\r\nfbv{x>325:R,m>2480:R,x>134:A,A}\r\nzz{a>2965:A,x>2929:R,x<2695:A,A}\r\nnp{a>3482:A,x<3481:A,A}\r\nsbs{s<259:A,x<1379:A,R}\r\nbn{m>3500:R,s<1981:A,R}\r\nrxv{x>2424:gml,a>3161:rpt,a<2452:qp,nl}\r\nrrz{m>1386:A,A}\r\nbpn{s<3253:A,m<2833:A,A}\r\nhvk{s>893:qtn,s>718:fp,ps}\r\nxzt{s<214:A,a<2852:A,a<3195:A,A}\r\ngt{m<2278:dvf,x<488:zlm,s>2549:A,tvf}\r\nnk{m>2791:kxp,bbf}\r\nsx{x>429:A,A}\r\nhvr{m>1538:vmr,x>3824:zjh,R}\r\nvd{m<1786:A,A}\r\nhgs{m<3070:R,R}\r\nvlk{a<1234:cl,bmn}\r\nlnq{a<2399:A,A}\r\nxbq{s>361:zmh,x>1853:A,A}\r\njcc{m<2771:bm,s<3604:ssm,a<1271:A,R}\r\njpx{m>3485:A,x>558:phc,m>3423:tt,A}\r\nhfq{x<2572:zbr,xt}\r\nbkc{m>3587:xrm,bx}\r\nsn{m>847:cqp,mvz}\r\nnq{x<785:ms,vd}\r\nlt{a>3074:R,hx}\r\ngl{s<547:nb,m>1232:gqm,lm}\r\nvk{s>2248:R,x>1018:R,x>875:A,R}\r\nnh{s<2219:A,R}\r\nrkd{a>1307:R,m>3778:R,s>3005:R,A}\r\npl{m>532:nx,ckf}\r\ncvc{m<2242:llj,s>2486:lx,spt}\r\nxlt{x<1412:gm,R}\r\ntlh{s<680:R,m>1528:R,R}\r\nxcb{m>816:R,m<635:R,R}\r\nrf{a<3404:R,a<3430:A,s>3097:A,A}\r\nnpm{a>2858:zc,m<2822:gvj,vpp}\r\nvb{x>516:R,a<1732:R,a<1881:A,A}\r\nrbz{m>1164:R,m>1031:R,R}\r\ndpg{m<2841:R,A}\r\ndjj{x<2363:A,x<2667:A,R}\r\njg{m>3682:R,x<1403:R,s<1039:A,R}\r\njkc{a<1057:kvg,x<1649:brh,R}\r\nbm{x>529:A,s>3739:R,A}\r\nmvz{a>2875:A,x>2783:R,a<2598:mgm,vp}\r\nszc{s<471:zx,R}\r\njb{x<659:R,x>709:R,x>676:dt,R}\r\nmb{a>173:R,a<102:R,R}\r\nqcp{m>2929:gkj,m>2762:dpg,x>412:mk,R}\r\npld{m<1537:A,s<834:gv,m>1601:hxz,R}\r\npzt{m>2415:pkc,m<2185:A,x<753:bs,A}\r\njq{a<3196:A,s<241:A,A}\r\nhcd{s<2451:R,x>1173:A,A}\r\nnj{x<2302:R,x<2582:R,a<2520:A,R}\r\nfpt{a<3130:R,A}\r\ncbt{s>2382:R,s>2035:A,x<3432:A,A}\r\ntjp{a>2112:tlh,m>1498:ngr,a>994:R,vtg}\r\nxjm{a<583:vjh,m<3559:fhm,cqv}\r\npg{s<2659:R,m<3065:R,s<3521:A,A}\r\nrs{m<3568:R,s<2122:R,R}\r\ntdg{a>716:R,s>1859:R,m<2373:R,R}\r\nvjr{s<3323:A,m<887:R,s>3746:R,R}\r\nqz{a<3160:pgt,nm}\r\ntk{x>369:R,x<184:A,x<290:A,R}\r\nqmq{m<2599:R,x<2042:R,a<1683:A,A}\r\ntv{x<344:A,x<362:R,A}\r\npbm{x>798:R,s<2731:xq,A}\r\njj{m>2323:tk,s>2354:vx,x<498:R,R}\r\nqgp{s>1012:A,R}\r\nph{x<1029:R,R}\r\nhp{s>3534:R,R}\r\nxrm{s<3121:cp,x<2635:R,s>3518:R,R}\r\nxmf{a<675:zkb,a<1132:mmn,s<2787:gj,gxl}\r\njtd{a<2647:nml,lkf}\r\ndnd{m<3828:dcc,hmr}\r\nzj{a<1710:jb,m>522:pgn,s>3129:tsc,sxt}\r\ncz{s>3009:jc,zzv}\r\nhck{s<2868:jzg,m<2279:px,x<1200:gp,A}\r\nfdl{m<1066:qbq,hs}\r\nqs{a<3302:R,x>1926:R,x>1732:rf,cxv}\r\nggg{s<517:A,R}\r\nqr{a>3785:ssr,a<3690:dfv,hck}\r\ntjf{m>3817:A,R}\r\nxmk{a<1412:mf,x<3641:pld,m<1591:hvr,pb}\r\nkp{s>2187:R,x>165:A,A}\r\nfg{x<399:csz,x>551:zj,a<1392:jk,qpj}\r\nthg{m<3389:R,a>1107:R,R}\r\nzqz{x>596:A,x>213:R,R}\r\nqc{x<2322:A,mb}\r\nvv{m<1712:dz,tl}\r\npbv{m<2080:mhd,s<878:tc,plt}\r\npx{a<3748:A,A}\r\njzg{a>3732:R,A}\r\ntlp{x<3026:R,a>2164:R,m>353:A,R}\r\nxzl{s>159:R,x<3229:R,x>3323:R,R}\r\nzmh{s>488:A,x<1954:R,A}\r\ntf{s>209:R,s<81:R,R}\r\nvq{m<1053:R,a<2219:vll,A}\r\nglz{m<2247:A,x>725:R,m<2273:R,R}\r\nzkj{m<2706:R,s<3737:A,s>3825:R,A}\r\nnf{m<397:R,s>1752:R,s>1617:A,A}\r\ngfk{m>3145:pv,m>2600:rt,a>2976:gcp,dx}\r\njhg{s>3608:djh,R}\r\nhlq{x>2998:grj,R}\r\ndv{s<2926:R,s<3607:A,x>402:dq,fpt}\r\nfh{m>3713:A,m<3664:A,s<1671:A,R}\r\nzzb{a<161:A,A}\r\npkc{x>535:R,s<2008:A,a<1368:R,A}\r\ndg{m>2360:A,bgg}\r\ncx{s>2101:A,x>475:A,s<1778:R,R}\r\nzss{a>2883:R,s<2474:R,A}\r\nnx{s>3208:vxm,s>3008:tdx,R}\r\ngh{s>107:A,m<2657:R,A}\r\nqrh{x>1346:A,m<2388:R,m<2525:R,A}\r\nzv{x>3110:R,R}\r\njm{a>1039:A,s<2431:R,A}\r\nkj{m>2931:nh,vk}\r\njd{s>2473:lt,s<2087:ktc,kj}\r\nmhd{a<3200:R,x<2076:R,qqz}\r\nzzv{m>1041:A,A}\r\nkrh{s>1661:xjl,m<446:R,rzt}\r\ntsj{x<132:R,m>834:nc,zss}\r\njzz{x>368:R,A}\r\nxt{a<1846:gr,s<470:th,jbz}\r\nkxs{m>3533:R,a>1643:A,R}\r\npvv{s>3049:A,a>280:R,m<2872:A,bn}\r\nzt{m>312:A,R}\r\nprz{a>1630:R,A}\r\ndcc{s<2488:qn,A}\r\nppp{s>555:qgp,ct}\r\nsgl{x<1049:kxs,m>3295:dbx,ml}\r\nxrs{a<3128:R,R}\r\nqd{s<3697:A,s>3883:A,m<256:A,R}\r\nmg{a>1779:A,A}\r\nkvd{s>2370:mkz,a<2669:lvz,m<2375:ks,hl}\r\ngp{s>3412:A,m>2453:R,s<3190:A,A}\r\ngs{m<3214:hnp,a>1327:R,m<3478:R,R}\r\ndq{m<2294:A,a<3133:R,s>3809:R,R}\r\nfhm{m>3214:mq,a<1065:sgn,m<3095:mkg,nzh}\r\nkqg{m<471:kt,ngj}\r\ngvj{x>3475:dkt,m<2753:A,kq}\r\nbbm{a<2651:R,x<1934:R,a<2930:A,A}\r\nsr{a>523:grp,a<289:nbd,hq}\r\nzx{x>1522:R,s<413:R,x>551:R,R}\r\nrx{a>2719:R,a<2394:A,x>892:R,A}\r\nnsj{a<2290:gqp,lj}\r\nht{m>1276:kqs,x>1383:vr,x<809:fg,jpb}\r\nrfj{a>1363:hz,x<924:jzz,x<1249:rvd,gjv}\r\nrdr{a>3396:R,x<490:A,s>1707:A,A}\r\nllz{m<2526:A,a>2958:A,A}\r\nvp{s<2776:R,m>438:A,R}\r\nbxs{m>3075:kxz,s>2929:rxv,bz}\r\nzh{s<2067:krh,m>838:vq,m>452:xj,qg}\r\nmv{s<2553:R,a>2583:A,R}\r\nlq{s<3384:A,s<3723:A,a<502:R,A}\r\nhk{a<2548:pfz,s>3580:lms,qf}\r\nfl{x>561:A,a<1018:R,A}\r\nqxl{a>469:R,xh}\r\nbfn{x<471:R,a>2998:R,s>903:A,A}\r\nhtd{m<2745:A,A}\r\nlms{s<3778:R,A}\r\nmjv{x<1153:A,A}\r\nnqx{x>2835:cbt,a<271:zzb,a<391:djj,R}\r\ndt{s<2326:A,x<694:R,R}\r\nspr{m>1944:A,a>3045:pzp,x>1013:sbs,hgz}\r\njx{s>2889:R,m<279:qcd,x>487:A,sx}\r\ntrb{a<1977:R,a>2166:A,A}\r\nzs{a>3142:A,x<1091:R,R}\r\nvr{a>2273:sn,m>843:cz,s>2681:pl,vlk}\r\ngsj{x<2446:qx,s>79:gh,a<3044:A,np}\r\nsc{m>2483:A,R}\r\nnc{a<2727:A,s<2752:R,m<1032:A,A}\r\npmz{x>2124:A,a>3726:kfm,A}\r\nrzv{m>2612:A,a>17:A,A}\r\npkk{m<2591:sc,R}\r\nqv{m>2307:R,nj}\r\nmkz{m>2298:rx,m<2213:ph,a<2681:R,glz}\r\ntxg{s>1691:R,A}\r\nkxp{x<2013:A,R}\r\njc{m<1072:A,a<1090:lq,s<3550:hd,R}\r\nzpx{a>639:R,a>349:R,x<3587:R,A}\r\ncm{m>1760:R,R}\r\nzqv{x<1298:A,a<689:A,a<1166:R,R}\r\nbj{x>424:R,s<2808:A,a<2043:A,A}\r\nkmt{x>2294:tlp,s>566:R,x>1268:A,A}\r\nkm{s<2922:A,a>3666:R,a>3644:R,A}\r\nhnp{x>507:R,x>187:A,R}\r\nctf{m<1863:A,x<1658:A,A}\r\nlb{m>2935:A,s>1913:R,s>1845:R,R}\r\nzqt{a>3510:gt,a<3321:dv,s>2328:dtx,fcr}\r\nzbr{s<567:sgl,lrf}\r\nfdz{x<2671:rh,a>121:R,A}\r\nnhd{a<3761:A,s>849:R,a<3857:R,A}\r\nqpp{a>2654:A,m<2211:R,A}\r\nbmn{x<3088:R,a<1847:A,gcj}\r\nfkv{m>1512:A,x<3170:R,x>3258:A,A}\r\nsv{x>2547:R,R}\r\ndkt{x>3767:R,s<2076:R,s<2423:A,A}\r\ndbd{x<944:R,x<1326:A,A}\r\nxg{a<3113:A,m>3707:A,s<1469:A,R}\r\nphc{s<1991:R,x>1172:R,x<840:A,R}\r\nphf{s>1933:kg,s<1674:R,x>508:A,R}\r\npqp{m>2786:A,s>1514:R,R}\r\ngj{m<2941:pzt,m>3643:phf,gs}\r\nrvd{a<1252:R,s>3015:R,R}\r\nknm{s<2302:tdg,m<2584:jlk,htd}\r\nclh{x>2113:R,a>2983:A,fqm}\r\nssm{s>3366:A,A}\r\nzzs{s<2716:pz,x<1486:nq,m<1843:pc,smm}\r\nnxx{a<86:R,m<3157:R,s>3477:R,A}\r\ncsz{x>235:df,a>2090:tsj,s<2596:xp,zb}\r\nlvz{x<566:R,m<2338:hf,fhz}\r\nkqc{m>3000:A,a<1259:R,x>2607:A,A}\r\npdq{s>3502:jtd,m>734:fdl,kh}\r\nnzh{s<2592:R,s>3085:R,R}\r\nkq{x<3010:R,a>2121:A,s<2261:A,A}\r\njxr{m<2447:A,a<1841:A,a<2096:A,bpn}\r\nplt{a>3255:kl,bbm}\r\nhkg{m>1491:R,djv}\r\nxq{a<399:A,x<652:R,R}\r\nrjt{a<3053:A,a>3622:R,R}\r\ncxv{x>1677:A,R}\r\nhf{s<1982:R,x<1260:R,x>1414:R,A}\r\nmc{a<1706:R,x<2072:A,A}\r\nbbf{m<2692:R,a<2801:R,R}\r\nbfg{x<492:A,hsm}\r\nvc{a>1052:R,s<3558:R,A}\r\nff{x<3072:R,s<333:xzl,x<3262:sz,R}\r\ngjv{m<2383:A,A}\r\ndf{a<2151:xfz,tv}\r\nqg{m>298:sj,pkx}\r\nxxp{m<2001:ctf,x<1555:R,a<853:A,rxb}\r\ngkj{a<3512:R,R}\r\nzf{a<2136:hvk,m<2363:pbv,knz}\r\n\r\n{x=270,m=803,a=872,s=703}\r\n{x=168,m=751,a=718,s=82}\r\n{x=153,m=830,a=1600,s=1613}\r\n{x=335,m=2651,a=45,s=535}\r\n{x=1744,m=2707,a=2054,s=421}\r\n{x=792,m=2226,a=694,s=2812}\r\n{x=2839,m=2056,a=3184,s=1188}\r\n{x=136,m=2452,a=76,s=610}\r\n{x=917,m=1348,a=184,s=1413}\r\n{x=1109,m=1790,a=648,s=1026}\r\n{x=1397,m=450,a=1618,s=714}\r\n{x=486,m=1721,a=1685,s=718}\r\n{x=2719,m=106,a=910,s=447}\r\n{x=623,m=1151,a=772,s=1053}\r\n{x=977,m=493,a=1463,s=2396}\r\n{x=499,m=270,a=3225,s=760}\r\n{x=70,m=2583,a=2786,s=300}\r\n{x=39,m=2807,a=3758,s=133}\r\n{x=1875,m=2332,a=869,s=2285}\r\n{x=2498,m=1034,a=2958,s=2313}\r\n{x=412,m=596,a=1271,s=295}\r\n{x=59,m=2215,a=3630,s=331}\r\n{x=1357,m=240,a=630,s=15}\r\n{x=48,m=1507,a=269,s=1936}\r\n{x=394,m=844,a=923,s=660}\r\n{x=227,m=436,a=2767,s=792}\r\n{x=27,m=773,a=586,s=987}\r\n{x=574,m=40,a=166,s=99}\r\n{x=1818,m=379,a=1740,s=908}\r\n{x=507,m=419,a=300,s=1289}\r\n{x=241,m=1679,a=226,s=235}\r\n{x=98,m=2248,a=1826,s=1645}\r\n{x=1608,m=752,a=1752,s=1596}\r\n{x=491,m=1129,a=780,s=2579}\r\n{x=41,m=2383,a=1346,s=336}\r\n{x=2266,m=755,a=248,s=29}\r\n{x=610,m=378,a=533,s=1732}\r\n{x=1681,m=935,a=2270,s=2267}\r\n{x=2150,m=1331,a=1113,s=3004}\r\n{x=689,m=261,a=1010,s=1711}\r\n{x=991,m=225,a=1468,s=2326}\r\n{x=18,m=1705,a=1963,s=664}\r\n{x=28,m=546,a=2929,s=92}\r\n{x=3391,m=440,a=1644,s=2483}\r\n{x=859,m=1340,a=508,s=25}\r\n{x=865,m=654,a=578,s=3020}\r\n{x=1297,m=144,a=172,s=611}\r\n{x=691,m=1975,a=1682,s=368}\r\n{x=5,m=3220,a=1769,s=356}\r\n{x=1974,m=1287,a=1944,s=215}\r\n{x=345,m=421,a=2361,s=2440}\r\n{x=1009,m=351,a=431,s=410}\r\n{x=749,m=836,a=40,s=79}\r\n{x=2735,m=2444,a=3141,s=813}\r\n{x=74,m=12,a=2040,s=3428}\r\n{x=20,m=188,a=14,s=1207}\r\n{x=1123,m=108,a=591,s=35}\r\n{x=184,m=410,a=22,s=251}\r\n{x=146,m=1425,a=833,s=1064}\r\n{x=2551,m=1056,a=1433,s=1569}\r\n{x=1883,m=1442,a=108,s=646}\r\n{x=804,m=14,a=1000,s=1944}\r\n{x=160,m=104,a=1040,s=2738}\r\n{x=1185,m=651,a=2981,s=1563}\r\n{x=43,m=1746,a=512,s=1247}\r\n{x=386,m=1151,a=1189,s=1107}\r\n{x=2118,m=2914,a=226,s=75}\r\n{x=3542,m=3035,a=1877,s=584}\r\n{x=120,m=1243,a=575,s=8}\r\n{x=3828,m=1207,a=124,s=7}\r\n{x=142,m=1824,a=2620,s=574}\r\n{x=622,m=713,a=354,s=1178}\r\n{x=107,m=671,a=142,s=446}\r\n{x=230,m=581,a=1034,s=1436}\r\n{x=622,m=521,a=440,s=2084}\r\n{x=671,m=717,a=224,s=535}\r\n{x=64,m=818,a=1947,s=214}\r\n{x=74,m=1639,a=441,s=1224}\r\n{x=625,m=1559,a=3240,s=134}\r\n{x=1738,m=2097,a=197,s=511}\r\n{x=884,m=2434,a=178,s=1287}\r\n{x=1524,m=773,a=201,s=1309}\r\n{x=99,m=24,a=3313,s=812}\r\n{x=216,m=97,a=2561,s=182}\r\n{x=2981,m=399,a=383,s=252}\r\n{x=61,m=439,a=671,s=1747}\r\n{x=309,m=3,a=8,s=2011}\r\n{x=74,m=958,a=87,s=896}\r\n{x=100,m=661,a=1197,s=174}\r\n{x=391,m=284,a=2173,s=348}\r\n{x=1477,m=1641,a=150,s=1475}\r\n{x=1376,m=801,a=10,s=221}\r\n{x=706,m=1658,a=415,s=2618}\r\n{x=137,m=13,a=1319,s=264}\r\n{x=754,m=940,a=245,s=362}\r\n{x=1977,m=987,a=206,s=1058}\r\n{x=1652,m=194,a=1058,s=1236}\r\n{x=66,m=297,a=2194,s=339}\r\n{x=1440,m=1819,a=200,s=923}\r\n{x=221,m=35,a=2729,s=1582}\r\n{x=145,m=503,a=160,s=2628}\r\n{x=643,m=772,a=1129,s=634}\r\n{x=1580,m=5,a=847,s=503}\r\n{x=2069,m=370,a=447,s=465}\r\n{x=2794,m=92,a=1234,s=1493}\r\n{x=2752,m=215,a=305,s=1296}\r\n{x=1769,m=449,a=1991,s=210}\r\n{x=1513,m=405,a=1029,s=1594}\r\n{x=1260,m=1937,a=327,s=959}\r\n{x=165,m=557,a=1077,s=3128}\r\n{x=1263,m=180,a=19,s=72}\r\n{x=369,m=173,a=530,s=1370}\r\n{x=331,m=639,a=567,s=263}\r\n{x=1046,m=2303,a=32,s=461}\r\n{x=106,m=160,a=18,s=1293}\r\n{x=1202,m=48,a=644,s=155}\r\n{x=1411,m=1973,a=68,s=1002}\r\n{x=3082,m=1684,a=1314,s=2303}\r\n{x=781,m=414,a=885,s=341}\r\n{x=294,m=2955,a=2670,s=268}\r\n{x=913,m=49,a=378,s=1057}\r\n{x=67,m=1402,a=910,s=310}\r\n{x=304,m=2341,a=214,s=1026}\r\n{x=668,m=478,a=1233,s=363}\r\n{x=2275,m=3714,a=12,s=57}\r\n{x=2603,m=591,a=1357,s=1809}\r\n{x=7,m=511,a=3472,s=1883}\r\n{x=1305,m=2652,a=1194,s=227}\r\n{x=308,m=2241,a=416,s=2248}\r\n{x=83,m=3545,a=3477,s=372}\r\n{x=2771,m=1273,a=1640,s=816}\r\n{x=3080,m=174,a=542,s=724}\r\n{x=209,m=70,a=534,s=210}\r\n{x=452,m=114,a=679,s=1008}\r\n{x=771,m=294,a=338,s=1258}\r\n{x=1730,m=826,a=345,s=27}\r\n{x=2901,m=1038,a=1499,s=2199}\r\n{x=2066,m=3193,a=957,s=393}\r\n{x=130,m=3257,a=2250,s=253}\r\n{x=235,m=987,a=278,s=597}\r\n{x=2465,m=1268,a=1893,s=2360}\r\n{x=940,m=470,a=435,s=1386}\r\n{x=958,m=392,a=79,s=18}\r\n{x=1513,m=2440,a=1287,s=36}\r\n{x=84,m=361,a=3217,s=28}\r\n{x=2451,m=2374,a=57,s=1242}\r\n{x=251,m=1008,a=1114,s=1458}\r\n{x=2058,m=46,a=657,s=989}\r\n{x=2398,m=463,a=1753,s=917}\r\n{x=1181,m=2013,a=4,s=2832}\r\n{x=1548,m=271,a=6,s=218}\r\n{x=1934,m=240,a=410,s=954}\r\n{x=2328,m=1860,a=1111,s=1487}\r\n{x=2370,m=27,a=694,s=1372}\r\n{x=2299,m=350,a=669,s=360}\r\n{x=2010,m=2306,a=700,s=1297}\r\n{x=349,m=2569,a=223,s=352}\r\n{x=50,m=343,a=49,s=17}\r\n{x=1980,m=82,a=20,s=1637}\r\n{x=1336,m=1955,a=269,s=264}\r\n{x=154,m=3620,a=2,s=818}\r\n{x=623,m=3021,a=2297,s=1911}\r\n{x=2981,m=2825,a=1290,s=69}\r\n{x=493,m=534,a=1029,s=3961}\r\n{x=44,m=1352,a=1311,s=1147}\r\n{x=920,m=389,a=2045,s=1441}\r\n{x=1166,m=930,a=1522,s=291}\r\n{x=51,m=673,a=2995,s=496}\r\n{x=950,m=557,a=24,s=1444}\r\n{x=1261,m=2375,a=234,s=1565}\r\n{x=303,m=464,a=645,s=923}\r\n{x=2077,m=287,a=740,s=1523}\r\n{x=1813,m=370,a=1529,s=111}\r\n{x=861,m=2269,a=1182,s=2074}\r\n{x=111,m=1145,a=543,s=326}\r\n{x=504,m=468,a=2391,s=990}\r\n{x=1701,m=1719,a=2574,s=331}\r\n{x=1123,m=70,a=754,s=2870}\r\n{x=6,m=1068,a=1404,s=2472}\r\n{x=991,m=1306,a=767,s=2885}\r\n{x=50,m=980,a=947,s=856}\r\n{x=1450,m=580,a=869,s=229}\r\n{x=684,m=486,a=1191,s=2639}\r\n{x=100,m=1569,a=66,s=644}\r\n{x=1756,m=138,a=1347,s=3488}\r\n{x=1403,m=562,a=726,s=619}\r\n{x=601,m=2128,a=43,s=953}\r\n{x=40,m=160,a=73,s=161}\r\n{x=556,m=2694,a=792,s=22}\r\n{x=505,m=1755,a=2185,s=391}\r\n{x=2545,m=3215,a=850,s=430}\r\n{x=1256,m=153,a=112,s=1132}\r\n{x=2016,m=2104,a=408,s=2138}\r\n{x=238,m=1081,a=645,s=882}\r\n{x=1735,m=620,a=52,s=34}\r\n{x=39,m=125,a=655,s=269}\r\n{x=233,m=1962,a=601,s=248}\r\n{x=284,m=2418,a=468,s=17}\r\n{x=864,m=2542,a=1040,s=399}\r\n{x=229,m=152,a=753,s=285}";

            var lines = input.Replace("\r\n", "\n").Split('\n').ToList();

            var rules = new Dictionary<string, List<(string eval, string move)>>();
            bool ruleParese = true;
            long sum = 0;
            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i];
                if (string.IsNullOrEmpty(line))
                {
                    var possiblevalues = new Dictionary<char, (int min, int max)>();
                    possiblevalues['x'] = (1, 4000);
                    possiblevalues['m'] = (1, 4000);
                    possiblevalues['a'] = (1, 4000);
                    possiblevalues['s'] = (1, 4000);

                    var stack = new Stack<(string name, Dictionary<char, (int min, int max)> values)>();
                    stack.Push(("in", possiblevalues));

                    while (stack.Count > 0)
                    {
                        var workflow = stack.Pop();
                        foreach (var (eval, move) in rules[workflow.name])
                        {
                            var possible = new Dictionary<char, (int min, int max)>(workflow.values);

                            char category = eval[0];
                            if (eval != "true")
                            {
                                int y = int.Parse(eval.Substring(2));
                                if (eval[1] == '<')
                                {
                                    possible[category] = (possible[category].min, Math.Min(possible[category].max, y - 1));
                                    workflow.values[category] = (Math.Max(workflow.values[category].min, y), workflow.values[category].max);
                                }
                                else
                                {
                                    possible[category] = (Math.Max(possible[category].min, y + 1), possible[category].max);
                                    workflow.values[category] = (workflow.values[category].min, Math.Min(workflow.values[category].max, y));
                                }
                            }

                            if (move == "R")
                                continue;

                            if (move == "A")
                            {
                                long product = (long)(possible['x'].max - possible['x'].min + 1)
                                    * (possible['m'].max - possible['m'].min + 1)
                                    * (possible['a'].max - possible['a'].min + 1)
                                    * (possible['s'].max - possible['s'].min + 1);
                                Console.WriteLine($"A: {possible['x']} {possible['m']} {possible['a']} {possible['s']} product:{product}");
                                sum += product;
                                continue;
                            }

                            stack.Push((move, possible));
                        }
                    }
                    Console.WriteLine(sum);
                    sum = 0;

                    ruleParese = false;
                    continue;
                }

                if (ruleParese)
                {
                    var data = line.TrimEnd('}').Split('{');
                    var name = data[0];
                    var workflow = new List<(string, string)>();
                    foreach (var item in data[1].Split(','))
                    {
                        var elements = item.Split(':');
                        if (elements.Length == 1)
                            workflow.Add(("true", elements[0]));
                        else
                            workflow.Add((elements[0], elements[1]));
                    }
                    rules.Add(name, workflow);
                }
                else
                {
                    var row = line.TrimStart('{').TrimEnd('}').Split(',');
                    int x = int.Parse(row[0].Substring(2));
                    int m = int.Parse(row[1].Substring(2));
                    int a = int.Parse(row[2].Substring(2));
                    int s = int.Parse(row[3].Substring(2));

                    string state = "in";
                    while (state != "A" && state != "R")
                    {
                        foreach (var (eval, move) in rules[state])
                        {
                            if (Eval(eval, x, m, a, s))
                            {
                                state = move;
                                break;
                            }
                        }
                    }

                    if (state == "A")
                        sum += x + m + a + s;
                }
            }
            Console.WriteLine(sum);
        }

        private static bool Eval(string eval, int x, int m, int a, int s)
        {
            if (eval == "true")
                return true;

            int value = 0;
            switch (eval[0])
            {
                case 'x':
                    value = x; 
                    break;
                case 'm':
                    value = m;
                    break;
                case 'a':
                    value = a;
                    break;
                case 's':
                    value = s;
                    break;
            }

            return eval[1] == '<' ? value < int.Parse(eval.Substring(2)) : value > int.Parse(eval.Substring(2));
        }
    }
}
