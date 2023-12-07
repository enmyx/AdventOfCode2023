using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sinput = "32T3K 765\r\nT55J5 684\r\nKK677 28\r\nKTJJT 220\r\nQQQJA 483";
            var input = "55559 2\r\nQ525J 656\r\n457J4 324\r\nT6668 259\r\n38847 640\r\n777T3 595\r\nJ545J 876\r\n25554 748\r\n353T3 974\r\n6KQKK 178\r\nA3353 31\r\n23239 195\r\nJ3TTT 238\r\n897A3 580\r\nQAKJ3 701\r\nJ6758 273\r\n666J8 475\r\nA4K5K 241\r\n9T4TJ 32\r\nK9K4J 786\r\n69666 472\r\nAJKAT 389\r\n8Q73J 204\r\n9K8KK 780\r\n886J4 855\r\n8T8TJ 828\r\n5TQA2 64\r\n3Q6Q6 638\r\nTTJTT 601\r\nK2J5K 338\r\nQQQTQ 196\r\nQ8JQ8 801\r\n7AK3J 437\r\nQ8535 1000\r\nK2JK3 853\r\nA3J86 672\r\nTJT9J 107\r\n89Q9K 127\r\nA794K 242\r\nJ8A22 819\r\n66688 690\r\n35357 861\r\nJK87J 864\r\n46KJ7 642\r\n829J5 890\r\n22JJJ 334\r\n4J959 795\r\n7365A 662\r\nA4449 579\r\nTT77J 809\r\n27456 239\r\n4K9T6 162\r\nJ44KJ 282\r\n5J55J 736\r\nT9ATT 648\r\nJ22TJ 7\r\n2T7TQ 28\r\n38338 723\r\n449Q4 505\r\nQJJQQ 408\r\nKKK5J 38\r\n4TJ87 867\r\n3T333 103\r\n65995 614\r\nTAQQ6 730\r\n79J57 822\r\n85K48 812\r\n9JA4A 140\r\n48J8A 966\r\n49J9Q 159\r\n223AK 113\r\nQ73Q7 6\r\n66J63 247\r\nTJ5TT 501\r\n9JKJJ 824\r\n893T7 13\r\n6JT42 46\r\n63JK3 210\r\n7J972 138\r\nA4KQ3 58\r\nK856K 154\r\n8TKAJ 255\r\n66333 615\r\nKKK48 585\r\n4QQ6Q 63\r\n43J5K 295\r\n72393 968\r\n3334Q 687\r\nQ4K6T 16\r\nT9T99 817\r\n3TK44 443\r\n22J53 686\r\nKQKKQ 40\r\n3K2TJ 848\r\n44JJ8 365\r\n36262 844\r\n55322 175\r\n2A622 973\r\nQQ3QQ 685\r\nAJT5A 919\r\n93J49 544\r\n93693 458\r\n9KKA9 892\r\n7278J 332\r\nT7QT3 562\r\nK2225 257\r\n5555T 912\r\n44844 435\r\nQQK48 863\r\n92A6J 322\r\nQ8Q29 775\r\n7T3JA 772\r\nT8855 887\r\n34Q59 167\r\nJTQ98 17\r\nAAA66 83\r\n58459 954\r\nA53Q6 37\r\nT6A4A 171\r\nQ2JKQ 732\r\n73Q52 714\r\n77787 82\r\n77J97 476\r\n229A2 744\r\nQ77QQ 271\r\n997J9 986\r\n7A9J2 98\r\nK8AQ4 155\r\n7J77J 409\r\n2A424 425\r\n2A522 297\r\n8488J 482\r\n69799 676\r\n33J73 635\r\nJJKKK 329\r\n8337T 826\r\nT5335 796\r\n99957 250\r\n88J22 494\r\n3K897 975\r\n55553 533\r\n58T5K 388\r\nJTTQ5 907\r\nJQ866 448\r\n6682J 706\r\nKQ8KK 807\r\nJT9T9 967\r\n63A9Q 720\r\nQK25T 488\r\n3JQ8J 893\r\nK2K7T 761\r\nK5QQ5 66\r\n35989 430\r\n6KK76 962\r\n35565 203\r\n9QT4K 752\r\n92722 59\r\n5A329 727\r\nK732Q 498\r\nQ9K3Q 994\r\n83336 766\r\n4A4T6 600\r\n9Q2KA 503\r\n8AAJJ 386\r\n35AAT 814\r\n555K5 265\r\n4AJ9T 774\r\nK5KK8 316\r\nAJAA3 378\r\n88K88 508\r\nKK3KK 213\r\nK8TA4 858\r\n84844 806\r\n22TT2 550\r\n92333 422\r\n44J48 412\r\n22555 842\r\n66686 940\r\n6666J 557\r\n28A77 143\r\n73737 390\r\n2J66A 996\r\n33232 570\r\n37A7Q 264\r\n74644 517\r\nKTTKK 1\r\nJJJKK 882\r\nJJ5J6 725\r\nQQA6Q 73\r\n88J8J 914\r\n7KK77 590\r\n27JQJ 964\r\nA6AAA 307\r\n47363 692\r\n42Q2Q 125\r\n6T26T 916\r\n29K63 400\r\n969T9 869\r\n66366 120\r\n499K4 961\r\nA6444 715\r\n55454 755\r\n4K6QK 258\r\n8Q627 397\r\nQ2J8K 341\r\n8JJ36 988\r\n38888 232\r\nA69A9 756\r\nJ37J3 467\r\n59T95 39\r\n9QQQA 746\r\nQQQQ4 618\r\n6TT66 385\r\n27225 619\r\nJ44TJ 874\r\n92955 214\r\nJ4999 700\r\nTQQ56 303\r\n9J443 884\r\n43Q89 211\r\n75795 370\r\nQ5T7T 733\r\n2A287 199\r\n5KK22 709\r\n3T8QQ 891\r\n22A28 96\r\n5T5T5 308\r\n88KTK 469\r\nKJK8K 449\r\n3K97T 678\r\nT8Q66 377\r\n7TT9T 426\r\nA8979 228\r\nQ2984 833\r\nJ37KQ 513\r\nA5A5A 846\r\n66689 355\r\n457T3 717\r\n9949Q 424\r\n446QK 304\r\nA5TT5 313\r\n827KT 163\r\nJ6AQ9 767\r\n46KJ4 815\r\n34JJQ 432\r\n63J76 665\r\n79J96 598\r\nJ6288 710\r\nA555J 279\r\nQKTQQ 913\r\n55AA5 321\r\nKJK83 949\r\n2222J 49\r\n3KKAA 771\r\nA965Q 860\r\n6779Q 658\r\n8K539 769\r\n2K2Q8 121\r\n999J2 540\r\n8KK7K 284\r\n52284 67\r\nA2QJJ 466\r\nK7692 530\r\n9AQ2J 702\r\n9J66J 889\r\nQ2TAT 296\r\n3KTJ3 251\r\nJ44Q2 300\r\n272TT 941\r\nA979A 166\r\n88848 252\r\n383A8 54\r\n93K35 413\r\n336J6 173\r\nKK7QJ 76\r\n7J879 911\r\n88JQ8 145\r\n6A7A4 368\r\n37TJ7 612\r\n9K824 369\r\nTA2JQ 115\r\n3JATQ 576\r\n6T6Q6 468\r\n7TT77 743\r\nQ424K 291\r\nQAQJJ 224\r\nT7TT7 493\r\nAK6K8 177\r\n22226 776\r\n9QK59 179\r\n79625 481\r\nQJ785 489\r\nAT76K 945\r\nQ2Q2J 380\r\nAT3AT 248\r\n8QKK8 928\r\n44KKJ 47\r\nT9999 305\r\nJJJJJ 270\r\n3395Q 668\r\n8A6A8 803\r\nKKK55 754\r\n99939 454\r\nK7JKK 563\r\n33344 94\r\nAAAKA 144\r\n7TT3T 515\r\n686JJ 793\r\nJJ5T8 337\r\nQJ4Q9 549\r\nJA55A 281\r\n7QK7Q 641\r\n7J878 452\r\n546K8 484\r\n542A2 376\r\n86Q36 477\r\n9T248 105\r\nJQ955 41\r\nQ9336 810\r\n8JJJ8 765\r\n777JT 785\r\n2T7TK 261\r\n6K62A 611\r\nA667T 218\r\n52522 102\r\nQQ2KQ 554\r\n5T455 68\r\n66KK6 543\r\n8KT4J 111\r\nJK2T2 872\r\n89665 358\r\n67677 931\r\nK98J9 926\r\nTTTAA 578\r\n4236J 197\r\nKJTTT 731\r\nJ7777 302\r\n6226K 497\r\n44KK4 97\r\nQTQTQ 971\r\n9AAAA 541\r\n838J4 535\r\n65KA6 935\r\n85496 663\r\nJ9Q99 153\r\n544AA 269\r\n99J6J 43\r\n4QQQ4 721\r\n34T47 542\r\n6Q55J 627\r\n777A8 502\r\nT2T44 581\r\nKQA3T 346\r\n25524 506\r\n4377J 998\r\nKAQQ3 636\r\n3A777 277\r\n24224 707\r\n8JTT2 26\r\n47477 419\r\n8877Q 943\r\n39793 361\r\n5K586 904\r\n9K99K 832\r\nTTT9J 286\r\n93726 679\r\n22544 93\r\n2J692 840\r\n5964K 176\r\n2AKK6 898\r\nK454K 108\r\n7534A 114\r\n6J88T 939\r\n38883 231\r\n7KKK7 582\r\n87778 946\r\n444A4 101\r\nA9T27 100\r\nTTT6T 207\r\nQ9Q5A 459\r\n676K6 436\r\n438TJ 899\r\nQQJQQ 728\r\n7JA77 447\r\n83988 192\r\nK42A6 490\r\n7J867 556\r\nAAJ4T 9\r\nKJ999 633\r\n5AK72 407\r\n23276 81\r\n2K364 921\r\nQ999Q 718\r\nQQ5Q5 243\r\n8JJ72 254\r\n3T243 245\r\n66KAJ 888\r\nQ2AT3 363\r\n2J76Q 514\r\n5Q338 573\r\n95595 529\r\n68268 628\r\nAAQA7 797\r\nQQ5Q2 664\r\n3393Q 868\r\n693KT 670\r\n85895 862\r\nK3K63 288\r\nK2KK2 401\r\nK8525 565\r\nA233A 937\r\n66446 72\r\nJ8448 738\r\n927J2 532\r\nJT888 309\r\n5252J 834\r\nJK9JK 520\r\n5886J 8\r\n8AAAA 372\r\nA5A98 50\r\nAQQQQ 632\r\nQ5JT6 839\r\n2A996 768\r\n8659J 845\r\n47T37 745\r\nJ73TQ 586\r\n6K63K 836\r\n2333A 142\r\nA4493 566\r\nT2ATA 260\r\n69699 25\r\n5TTA6 367\r\n45Q4J 875\r\n8QJA7 574\r\nJ55K3 712\r\nTTTQT 548\r\nTT422 923\r\n4T63J 895\r\n4KKK4 325\r\n2Q287 762\r\n22225 34\r\nQ2646 596\r\nQQ758 492\r\n3TT22 800\r\nJA2JA 345\r\nQT3T2 830\r\n88525 348\r\n6AA58 500\r\n77K76 684\r\n32522 330\r\n224JJ 660\r\n5A72Q 593\r\n74572 151\r\n42442 592\r\n7KQ35 158\r\n373K7 485\r\n46A4Q 711\r\nQQ644 198\r\n74447 184\r\nT6T46 263\r\n74842 584\r\nT959K 328\r\n8883J 651\r\nJTAJ7 227\r\n86K79 930\r\nJQAKT 675\r\n6T688 607\r\n8QKA6 473\r\n666A6 693\r\n25KJ5 446\r\nJ39KQ 933\r\n733TT 873\r\nQQ2QQ 553\r\n266A6 75\r\n6AAKT 719\r\n6TJ95 156\r\n2KKQA 947\r\n7888T 877\r\n5A666 537\r\nT5462 547\r\n2J7T2 373\r\nQQ6Q6 680\r\n2A498 534\r\n52395 428\r\n544K5 42\r\n445A4 677\r\nAK554 220\r\n934K5 392\r\nA53AA 770\r\n99A99 314\r\nQJ456 272\r\nAA7AA 91\r\n7A77A 623\r\nKAA4J 30\r\n92229 92\r\nQ4Q4K 857\r\nJ4J7Q 782\r\n5QT5Q 897\r\nKKKK5 19\r\n77883 645\r\n33J63 349\r\nJ2T95 989\r\n98242 411\r\nQK33T 336\r\n395T4 546\r\nJ22J2 48\r\n7J8KT 496\r\n44K6A 52\r\n2K687 60\r\n44K4J 654\r\n9AKAK 375\r\n72J65 146\r\nAJJAJ 977\r\n99QJQ 705\r\n3AJ7J 716\r\n7KKT7 222\r\n2Q222 148\r\n8J3A7 249\r\nK6656 417\r\n23772 518\r\n2J229 495\r\nQQAKA 507\r\nJT27T 813\r\nAKT5T 416\r\n74676 821\r\nKKKK9 950\r\nTT335 301\r\nJ7TQ4 172\r\n437Q5 445\r\nQA562 395\r\nK7A2Q 777\r\n4TA87 818\r\n92929 217\r\n23777 237\r\n4KKQT 894\r\nA29Q3 283\r\n6AT7J 387\r\nJ4275 71\r\n47624 206\r\n4K7QJ 883\r\nJTQ6K 910\r\n33832 149\r\n7K227 708\r\n73KJ7 740\r\nK2K92 456\r\n2K9KT 753\r\n2222T 87\r\n55545 626\r\n333J3 917\r\n35K47 655\r\n52772 871\r\nQ9292 758\r\nT7Q7J 859\r\n2K4T3 352\r\n47QKA 504\r\nQT655 561\r\n46446 825\r\n767Q7 531\r\n2583A 4\r\n4A5K9 136\r\n6372Q 56\r\nQ8A44 229\r\n83333 567\r\nQJQQ7 152\r\nTQJQJ 669\r\n26AAT 524\r\nQ5T42 86\r\n37333 465\r\n3J833 922\r\n2J464 734\r\nAA2A2 99\r\n7QQ7J 306\r\nTJKA6 951\r\n99988 659\r\n9Q999 124\r\nAA99A 605\r\n97AQ5 326\r\n78TQK 132\r\n497Q2 21\r\n29222 866\r\n33753 538\r\nAK4KK 784\r\nJ5677 559\r\nKKK6J 781\r\n27222 643\r\n77833 671\r\nQ73Q4 440\r\nK5284 216\r\n28936 699\r\n6T6JT 790\r\n5J55T 139\r\n6966J 667\r\n6Q8Q8 741\r\n7777A 293\r\n7Q7Q7 410\r\n53J73 749\r\n27727 62\r\n9K6K4 331\r\n22AJQ 69\r\n797J9 778\r\n22A6J 637\r\n42AQ8 856\r\n484T4 35\r\n49494 483\r\nJA993 987\r\n2637K 617\r\n686AA 442\r\nJ4555 183\r\n87Q84 51\r\nKJ33K 423\r\n4TTKJ 421\r\nJK433 186\r\nAAA98 650\r\nJ5JJ5 886\r\n5K5K3 350\r\n536T5 80\r\n55K45 880\r\nK2TKT 783\r\nTTKK4 644\r\n9QQK9 499\r\n29K27 429\r\nQQ5JQ 333\r\nT6554 647\r\n7JK77 779\r\n3A55A 604\r\nA38AJ 480\r\n78828 603\r\n5J556 491\r\nKKJKK 674\r\n78J75 253\r\n98KK8 606\r\nQ2269 268\r\nAA28A 439\r\nKTTKT 391\r\n9559J 312\r\nQQ3TT 646\r\n85475 622\r\n57757 323\r\n53JJ3 317\r\n3K357 168\r\nT6K66 11\r\n5J572 757\r\n66488 575\r\n8KAT2 22\r\nAA77A 849\r\nT3QQ4 327\r\nT46Q4 18\r\n22QQ2 234\r\n8T88A 589\r\n37733 450\r\n33958 70\r\n89643 362\r\n6999J 609\r\n6T8T6 630\r\n22JT2 990\r\nJA759 631\r\n88KJK 275\r\n5Q5Q4 885\r\n8JJ84 742\r\n7K4J5 347\r\n42738 27\r\nTTT9T 901\r\n2AK3J 462\r\n7J7KK 344\r\n399A8 927\r\nQK3JQ 613\r\nK94A2 516\r\nQ769K 290\r\nQ8QQ8 564\r\n7ATQ4 794\r\n24K62 750\r\n77757 150\r\nTQ62T 55\r\n5Q5Q5 280\r\n3JJA6 583\r\n23333 847\r\nKKK6K 455\r\nJ779J 878\r\nJA87K 905\r\nJQQ3J 696\r\n7AA87 691\r\nKT77T 463\r\n7K777 77\r\n2T8J3 773\r\n37565 478\r\n8TK68 851\r\n67J27 119\r\n999J9 61\r\n85QAA 900\r\n2J232 639\r\nT9T9T 965\r\n5AKA5 703\r\nQQTT2 594\r\nJ5Q35 841\r\n55A53 319\r\n3535K 981\r\nAK3QA 135\r\n493AK 970\r\n72KT7 128\r\nK3J28 957\r\nQJ3JA 979\r\n2225T 983\r\n27A42 688\r\n5879T 335\r\nJ7J88 384\r\n6A6AK 160\r\nAAAAT 572\r\n98J2A 451\r\n6Q886 661\r\nQ6865 470\r\n2AA54 230\r\nKAKKJ 526\r\n696K6 393\r\n332J3 729\r\n32TQ3 320\r\n49T89 190\r\nA3AA3 798\r\n66654 963\r\nA2A7Q 382\r\n4TTJ4 147\r\n2886Q 934\r\nQJQTQ 959\r\nT8T48 112\r\n74K25 552\r\nAA4TA 116\r\n74777 854\r\n4J444 90\r\n8T5A4 624\r\n7A337 865\r\n22KK2 713\r\nA3Q22 95\r\nTTAJT 89\r\nJK554 545\r\nJJTTQ 629\r\n67KAJ 444\r\n66356 106\r\nKAKKA 903\r\n74979 925\r\nJ25QT 852\r\nKAJ44 379\r\n648K7 938\r\nTT5TT 20\r\nKJJ7J 558\r\n733J7 12\r\n6666K 999\r\n77776 404\r\nJ333J 510\r\n92959 993\r\nQ4528 811\r\nKJJ33 621\r\nQK557 406\r\n74773 980\r\n6TJ98 568\r\n8249J 433\r\n2T248 187\r\n34KK2 551\r\n98T99 956\r\n88Q28 225\r\n3J9T9 354\r\n67626 267\r\n888A3 835\r\n32K33 560\r\nJ8JJJ 982\r\nKQKKK 226\r\n37397 698\r\n5572Q 827\r\n7588J 170\r\nQ333A 695\r\n5T598 24\r\nKKK7K 522\r\nJJ999 881\r\nK6J55 521\r\n83382 764\r\nTTT2T 512\r\nQJ8TT 88\r\nQ5666 123\r\n335TK 118\r\n984T5 724\r\n36236 820\r\nQAQT5 918\r\nAA338 620\r\nQQ36Q 403\r\n39738 634\r\n44575 802\r\n5QQQQ 129\r\n35355 789\r\nKT3J8 805\r\n234JK 383\r\nAJ69J 486\r\nT455J 487\r\n5856J 460\r\n8K8K8 188\r\nJ37T6 180\r\n24TTT 681\r\n32222 587\r\nQ3Q25 126\r\nK437T 838\r\nQKQ7A 599\r\n9Q9QQ 972\r\n44344 14\r\nJ679T 36\r\n6QA7T 788\r\n98488 208\r\n47Q77 555\r\nQAQQ8 189\r\n32K8T 610\r\nA3TJA 294\r\n22955 185\r\nK64Q9 704\r\n5T92Q 33\r\n22882 577\r\nAAAA2 181\r\nAJJAA 464\r\nK58JK 194\r\nAA88A 653\r\n222K2 652\r\nT5A57 174\r\n776KQ 694\r\n8K822 597\r\n33399 353\r\n4Q942 396\r\nTJ838 829\r\n46Q63 953\r\nKK4KK 479\r\n5A7JQ 212\r\nT2932 244\r\nAA599 84\r\n9597T 474\r\n63J82 434\r\n82AJA 215\r\nQKJQK 235\r\n43344 209\r\n6TKKT 616\r\nQ222A 371\r\nAAAAJ 992\r\n98K34 246\r\nJ226J 747\r\n99979 399\r\n79779 274\r\nQA4AA 57\r\n2622Q 591\r\n22284 236\r\n5Q888 357\r\n666T6 133\r\n333TT 359\r\n5329Q 104\r\n77737 978\r\n43J74 299\r\n36365 906\r\nJT2T2 735\r\nKAJAK 527\r\nKQ2TA 74\r\n888A8 134\r\n88KT7 942\r\n24344 649\r\n94559 65\r\n3Q39Q 29\r\nK8AT7 471\r\nQ6832 256\r\n9AT7J 787\r\nT336T 266\r\n388JA 831\r\n4QAA4 278\r\nT8T88 3\r\n5TTT7 528\r\n47Q98 109\r\n85J7T 763\r\n22667 995\r\n2222A 45\r\n47AJQ 799\r\n6J94T 791\r\nAJ3A3 944\r\n5KJTT 523\r\n25927 233\r\nKQQ7Q 837\r\n9KKJ9 366\r\n9J7JQ 461\r\n5AAA2 816\r\n27722 360\r\n48385 625\r\n6K588 697\r\nQ3962 929\r\n29Q56 262\r\nJTKKT 997\r\nQ6628 374\r\nJQTQK 117\r\n44JJJ 850\r\n5JAQA 394\r\n2TK4J 588\r\n58TT2 936\r\n522TQ 991\r\n4444T 726\r\n8J33J 157\r\nTTTT4 201\r\nT353Q 342\r\nQ77Q5 310\r\n7KKKT 221\r\n83733 110\r\n9J5AA 722\r\n35993 984\r\n434T4 525\r\n2JKQ3 969\r\nJ5299 292\r\nT49QA 240\r\n6AAA3 955\r\nKA666 571\r\n98892 908\r\n33QKQ 405\r\nT92A8 509\r\nAJ349 137\r\n39939 427\r\nJ6435 79\r\n666A9 311\r\n22J47 15\r\nT57AJ 920\r\n555A5 760\r\nQK99J 985\r\n5AK79 169\r\n8J5JA 298\r\nKQ6KQ 438\r\n7TTTT 519\r\n37J32 44\r\nKK99Q 431\r\nKTTK3 414\r\n8JAJ6 960\r\n88868 536\r\n83439 870\r\nT3Q63 356\r\n77277 915\r\nATT6K 948\r\n76666 141\r\n68JT4 808\r\nAQQQA 823\r\n9K933 10\r\nKQ9QQ 219\r\n6J6A9 958\r\nA9JAQ 569\r\n79J3Q 418\r\nQ338J 843\r\n4TK98 287\r\n85885 289\r\n89842 339\r\n7K6JJ 343\r\n5K48A 976\r\nATJQT 804\r\n4J644 689\r\nQQQ7Q 739\r\n77978 453\r\n99499 420\r\nTKK4J 5\r\nK688K 285\r\n765QQ 608\r\nAA3AA 364\r\n55A2A 879\r\n8585J 318\r\nA8Q68 85\r\n45544 909\r\nQ4A8J 182\r\n7777T 759\r\nT3K55 165\r\nJ7377 276\r\n98282 666\r\nAAKAK 952\r\nQ38KA 122\r\n26AA6 130\r\nAJQAA 202\r\nJJT2T 205\r\nTA8TT 53\r\n227J6 932\r\n36J46 751\r\n8A88A 351\r\nT5AA5 200\r\n64885 792\r\nT44JK 457\r\n97656 683\r\nTTJJT 737\r\nT287T 381\r\n99298 402\r\n567JQ 398\r\n3729A 191\r\nKJ4AK 924\r\nTJTT6 682\r\nAJA5A 315\r\n5J555 164\r\n7T585 657\r\nK929T 78\r\n733A3 673\r\n596K8 23\r\nK5JK9 896\r\n6445J 340\r\n62626 223\r\n77999 441\r\n84A82 511\r\n4T4J4 131\r\n58585 539\r\n5A565 902\r\nJ8888 602\r\nQKJQQ 193\r\n6J638 415\r\nAATAT 161";
            var lines = input.Replace("\r\n", "\n").Split('\n');

            int sum = 0;

            var hands = new Dictionary<string, int>();
            var ranks = new List<Dictionary<List<int>, string>>();
            for (int i = 0; i < 7; i++)
            {
                ranks.Add(new Dictionary<List<int>, string>());
            }

            foreach (string line in lines)
            {
                var data = line.Split(' ');

                var cards = new List<int>();
                foreach (var card in data[0])
                {
                    int value = 0;
                    if (card == 'A')
                        value = 14;
                    else if (card == 'K')
                        value = 13;
                    else if (card == 'Q')
                        value = 12;
                    else if (card == 'J')
                        value = 1;
                    else if (card == 'T')
                        value = 10;
                    else
                        value = int.Parse(card.ToString());

                    cards.Add(value);
                }

                int rank = 0;
                if (cards.Contains(1))
                {
                    for (int i = 2; i <= 14; i++)
                    {
                        if (i == 11)
                            i++;

                        var replaced = new List<int>(cards);
                        int index = -1;
                        do
                        {
                            index = replaced.IndexOf(1);
                            if (index != -1)
                                replaced[index] = i;
                        } while (index != -1);

                        var newRank = GetRank(replaced);
                        if (newRank > rank)
                            rank = newRank;
                    }
                }
                else 
                    rank = GetRank(cards);

                hands.Add(data[0], int.Parse(data[1]));
                ranks[rank].Add(cards, data[0]);
            }

            int point = hands.Count;
            for (int rank = ranks.Count - 1; rank >= 0; rank--)
            {
                var sorted = ranks[rank].Keys.ToList();
                sorted = sorted.OrderByDescending(k => k[0])
                    .ThenByDescending(k => k[1])
                    .ThenByDescending(k => k[2])
                    .ThenByDescending(k => k[3])
                    .ThenByDescending(k => k[4])
                    .ToList();

                foreach (var hand in sorted)
                {
                    sum += point * hands[ranks[rank][hand]];
                    point--;
                }
            }

            Console.WriteLine(sum);
        }

        private static int GetRank(List<int> cards)
        {
            int rank = 0;
            var groups = cards.GroupBy(c => c);

            if (groups.Count() == 5) // high card
                rank = 0;
            else if (groups.Count() == 1) // five of a kind
                rank = 6;
            else if (groups.Count() == 4) // one pair
                rank = 1;
            else if (groups.Count() == 3)
            {
                if (groups.Any(g => g.Count() == 3)) // three of a kind
                    rank = 3;
                else // two pairs
                    rank = 2;
            }
            else
            {
                if (groups.Any(g => g.Count() == 4)) // four of a kind
                    rank = 5;
                else // full house
                    rank = 4;
            }

            return rank;
        }
    }
}
