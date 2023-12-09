﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = "LRLRRLLRRLRRRLRLRRRLLRRLLLLRRRLRRRLRRLRRLRRRLRRRLLRRLRLRRLRRRLLLRRLRRLLRLLRRRLRRRLLRLRRRLRLLRRLLLRLRRRLRRRLRRRLLRLRRRLLRRLRLRLLRRLRRRLRRLRLLRLRRRLRRLRLRLRRLRRRLRRRLRRRLRRLRRRLLRRLRRLLRRRLLRLRLRLRLLLRRLRLRRLRRLRRLRRLRRRLRRRLRLRRRLRLRRRLRRLRLLRLRRLRLRLLLRLLLRRRLRRLLLRLRRRR\r\n\r\nPNM = (QGP, BFT)\r\nHNH = (JPB, GMH)\r\nFNN = (DDN, PTB)\r\nVJS = (LHL, THF)\r\nKPV = (JFQ, TRN)\r\nBDQ = (BCP, LNN)\r\nSDC = (CVC, THN)\r\nMKN = (HXP, RHH)\r\nKXH = (FPR, GTC)\r\nTPD = (SPS, LFR)\r\nGQT = (TKX, SHR)\r\nCHM = (VBJ, SBV)\r\nFMR = (BSR, TTH)\r\nVVT = (PMJ, LDH)\r\nDCX = (KNH, GKT)\r\nHMK = (VNX, XRC)\r\nLDP = (JHJ, SLT)\r\nTBS = (QDR, PNM)\r\nQPG = (GFN, XGN)\r\nDRB = (CBX, NBL)\r\nBQP = (QQL, BVH)\r\nQRR = (TJT, DMP)\r\nCLL = (LMC, HXV)\r\nNLX = (CJS, RVR)\r\nDPT = (SKJ, TDH)\r\nGQV = (NDN, TPD)\r\nNTG = (MSK, VMX)\r\nLHP = (VBJ, SBV)\r\nJKC = (TLG, CNT)\r\nJKL = (GNF, RFM)\r\nKTS = (NKH, RJC)\r\nMHM = (SLG, JQX)\r\nZZZ = (LFM, MHM)\r\nMKB = (RQJ, GKB)\r\nLLC = (MBV, QKM)\r\nLNT = (XFG, CGX)\r\nXDB = (TSB, NSM)\r\nRFD = (DCT, TMM)\r\nBCL = (JXM, JXM)\r\nJTM = (CHM, LHP)\r\nGFN = (VRT, VSS)\r\nKBV = (FXC, JDS)\r\nTHM = (GMG, GMG)\r\nPPH = (KTK, MXN)\r\nRJD = (LQG, NHJ)\r\nQDQ = (GDQ, KQG)\r\nVJL = (QKM, MBV)\r\nNXN = (JGX, QKD)\r\nLQR = (BPL, CJF)\r\nVMM = (FMR, XMJ)\r\nDFA = (TJT, DMP)\r\nMHK = (XGH, SBK)\r\nQVR = (LKM, FNR)\r\nGMN = (DPT, TBK)\r\nCGX = (PTT, NSL)\r\nKSM = (CNT, TLG)\r\nBVH = (MQD, JSL)\r\nHHX = (FVT, PGL)\r\nJQH = (DCT, TMM)\r\nTTH = (VVT, GNH)\r\nGMG = (MHM, LFM)\r\nRMP = (XMV, MLT)\r\nSXH = (VJL, LLC)\r\nMGP = (SHN, GHV)\r\nGDQ = (VQM, TRH)\r\nXFG = (NSL, PTT)\r\nBLA = (XLR, VNR)\r\nRVL = (PQK, BQH)\r\nSTC = (THR, NQM)\r\nTLT = (TTK, GLQ)\r\nBKS = (XCC, SLX)\r\nQNP = (RQR, XPH)\r\nCKR = (TKG, MVD)\r\nSNQ = (LSP, SGQ)\r\nMCM = (THX, PXM)\r\nTHF = (CTS, QHD)\r\nPLT = (MTF, FRP)\r\nFRS = (KSN, RKG)\r\nRTB = (SRD, BDR)\r\nSGV = (BCL, BCL)\r\nNBL = (VKC, QJV)\r\nPTT = (HJT, TFN)\r\nSTJ = (CMM, JXD)\r\nCTP = (XFP, TLT)\r\nSRD = (DXH, DPG)\r\nKMP = (MRK, JHM)\r\nFXP = (NMP, QXT)\r\nHLL = (NKR, HSN)\r\nTNQ = (CVC, THN)\r\nTRQ = (KMP, LVQ)\r\nGGV = (HQQ, RRH)\r\nSDM = (JJB, DCG)\r\nFNB = (CBB, VXB)\r\nGBX = (CRK, NXN)\r\nFPB = (DGR, KPV)\r\nSJT = (STQ, JKL)\r\nLXC = (CQB, GSG)\r\nGTC = (PTF, XDB)\r\nVTT = (KVR, KVR)\r\nXMX = (RMN, JTD)\r\nFFP = (JNV, QPG)\r\nQBF = (TGN, TMP)\r\nCMB = (FQC, JNX)\r\nCJS = (NGV, GDB)\r\nVRM = (QJJ, LXC)\r\nMPG = (SGC, CHD)\r\nPRV = (GNT, QDP)\r\nCBH = (SQM, DRP)\r\nDDR = (MCM, BDK)\r\nFGM = (NDQ, SJQ)\r\nQHV = (FQC, JNX)\r\nQXF = (MVV, DRB)\r\nFFL = (BPX, KMG)\r\nKJM = (MVD, TKG)\r\nXBX = (QDR, PNM)\r\nFRD = (XPG, GDL)\r\nKDG = (CBB, VXB)\r\nKDM = (KVR, HPN)\r\nMCP = (HCQ, SHT)\r\nSVP = (LKM, FNR)\r\nLBC = (JLT, DVR)\r\nGXQ = (HSN, NKR)\r\nFSF = (NQS, QCK)\r\nPRF = (CNF, TKF)\r\nTPL = (DFS, MCH)\r\nDVR = (KDJ, QSR)\r\nLVT = (MKK, VCB)\r\nRHK = (LRM, JJV)\r\nMTJ = (KKQ, BDB)\r\nCCH = (MTJ, JGS)\r\nJDS = (KMQ, FNN)\r\nGPG = (BGT, MNM)\r\nXLC = (DDV, LVT)\r\nHMV = (TLC, LDT)\r\nJHJ = (HNX, XCF)\r\nQXT = (HLL, GXQ)\r\nNNS = (MRQ, FGM)\r\nPGL = (JLX, SKT)\r\nPPJ = (QTS, XVR)\r\nTSB = (JTK, LMH)\r\nJJV = (QJH, KCX)\r\nSSX = (BXM, BQC)\r\nQGP = (DLQ, MXH)\r\nTKX = (JCX, XRP)\r\nXQR = (BJG, GMN)\r\nSLX = (BLK, SJG)\r\nXGH = (DTT, MBM)\r\nSFM = (VTT, KDM)\r\nRRT = (RQJ, RQJ)\r\nHDC = (TKX, SHR)\r\nGQC = (CLL, SJR)\r\nHSN = (JTS, FLC)\r\nBLR = (NTL, LTR)\r\nJCS = (KMP, LVQ)\r\nBTG = (SDC, TNQ)\r\nGNT = (CVP, QBX)\r\nKVH = (TXL, MKX)\r\nLXS = (MGP, TTL)\r\nCTS = (QBL, NKN)\r\nLSP = (CXH, TGR)\r\nHLR = (JXD, CMM)\r\nMBM = (TCF, PRV)\r\nDNQ = (FRR, VNJ)\r\nGBK = (MSG, PDG)\r\nTTL = (SHN, GHV)\r\nSLG = (SPK, MFB)\r\nSGS = (RQC, TGB)\r\nKMQ = (DDN, PTB)\r\nMJJ = (RTK, LVN)\r\nJHM = (PGH, GGX)\r\nSMD = (JQS, FKR)\r\nJNP = (CMS, GSM)\r\nNDD = (MSK, VMX)\r\nXXK = (JVR, FSF)\r\nTXL = (RDM, VJS)\r\nMTF = (GTK, QJK)\r\nTTK = (KJM, CKR)\r\nNVL = (JLF, BNV)\r\nKHX = (KSS, GPG)\r\nFVR = (FVT, PGL)\r\nKSN = (VDX, SVM)\r\nFXF = (SQQ, TQC)\r\nNPS = (FKR, JQS)\r\nXVR = (CHL, PLN)\r\nMFB = (CFL, PBB)\r\nVXC = (LNT, MLQ)\r\nLHL = (CTS, QHD)\r\nTXX = (DMS, DFR)\r\nMQJ = (TXX, VMR)\r\nQPK = (JBH, KXM)\r\nLMC = (XLC, CRR)\r\nTFN = (JTM, RPB)\r\nPDG = (NKS, CBH)\r\nPGH = (PVM, XXK)\r\nKPX = (HXP, RHH)\r\nHLV = (BXM, BQC)\r\nJGK = (JCS, TRQ)\r\nKKQ = (SFK, MCF)\r\nPQF = (HBK, RMP)\r\nKXM = (RTB, FFQ)\r\nNPR = (QQT, SNQ)\r\nFRP = (QJK, GTK)\r\nDGX = (PDF, HCB)\r\nPLP = (KTK, MXN)\r\nTCM = (XFT, KPH)\r\nQQL = (JSL, MQD)\r\nQTS = (PLN, CHL)\r\nQFG = (RXM, PHM)\r\nJJB = (LXS, KTH)\r\nLGS = (VXF, BGH)\r\nMBV = (BTJ, BRH)\r\nBTJ = (FKB, QTL)\r\nVNR = (TKS, LQR)\r\nGVN = (PJR, XMX)\r\nXLL = (GSK, RXC)\r\nGNF = (RVL, BTC)\r\nLMD = (NXN, CRK)\r\nNNN = (QQK, BDQ)\r\nQBD = (VQR, XJB)\r\nGSM = (LVR, VMJ)\r\nNKN = (RFD, JQH)\r\nHMC = (GSK, RXC)\r\nLVN = (KDG, FNB)\r\nCBX = (QJV, VKC)\r\nRRF = (GQT, HDC)\r\nRCV = (XQR, HRK)\r\nDMS = (HNP, XKR)\r\nLXP = (LNJ, NVL)\r\nCFJ = (FXC, JDS)\r\nHPT = (BVS, FJQ)\r\nKTH = (TTL, MGP)\r\nXMV = (XNL, TDJ)\r\nSTQ = (RFM, GNF)\r\nSJQ = (GGG, NQF)\r\nLKM = (GVN, SVX)\r\nVKK = (DCG, JJB)\r\nTCF = (QDP, GNT)\r\nXMQ = (XFT, KPH)\r\nQMD = (JHJ, SLT)\r\nKHB = (KMG, BPX)\r\nVPR = (CSD, BTG)\r\nPJB = (GGN, TSC)\r\nTVP = (SGC, CHD)\r\nBPX = (GQV, PQM)\r\nTSH = (QMD, LDP)\r\nKCV = (NMP, QXT)\r\nTHX = (LMD, GBX)\r\nCFL = (CLR, GTN)\r\nFGK = (FJG, TRX)\r\nFKD = (XMJ, FMR)\r\nJVR = (NQS, QCK)\r\nRTK = (KDG, FNB)\r\nBHQ = (LPB, XMN)\r\nVNJ = (JGK, KHK)\r\nTMP = (JVK, PQF)\r\nKPT = (BNM, BVJ)\r\nQXX = (TMF, PNB)\r\nQBR = (HHX, FVR)\r\nTFL = (MCH, DFS)\r\nNQN = (DDR, RMX)\r\nLFG = (VTT, KDM)\r\nVDX = (SMD, NPS)\r\nVQM = (FPB, HGR)\r\nNDP = (SNQ, QQT)\r\nDGR = (JFQ, TRN)\r\nFFK = (VNJ, FRR)\r\nGTN = (DSP, MXS)\r\nMNH = (MCP, GFC)\r\nXRP = (KTT, BKX)\r\nLRM = (KCX, QJH)\r\nQKD = (TXT, MCK)\r\nVFH = (GMH, JPB)\r\nKVR = (THM, THM)\r\nMLQ = (CGX, XFG)\r\nRPB = (CHM, LHP)\r\nJNC = (BQS, TRT)\r\nRXC = (HRN, VKG)\r\nJLD = (QDH, SSP)\r\nTDJ = (LHC, KCB)\r\nVFQ = (JJV, LRM)\r\nFLC = (SSQ, HVF)\r\nXPH = (SXH, BVX)\r\nCXL = (HDC, GQT)\r\nJSL = (CGL, MJJ)\r\nKQG = (TRH, VQM)\r\nQJP = (PDG, MSG)\r\nTNP = (KMD, XMB)\r\nDQC = (QSL, DJF)\r\nQKK = (RRH, HQQ)\r\nHGR = (DGR, KPV)\r\nMXS = (GBK, QJP)\r\nBVX = (VJL, LLC)\r\nFRR = (KHK, JGK)\r\nQQT = (SGQ, LSP)\r\nKHL = (SCN, PRB)\r\nSKJ = (DLN, LJQ)\r\nTKS = (BPL, CJF)\r\nDTT = (PRV, TCF)\r\nNPV = (XFP, TLT)\r\nQHB = (NNS, RCZ)\r\nJPB = (GGS, KLG)\r\nNFQ = (BXH, FGK)\r\nDJF = (VVQ, QCT)\r\nMNF = (FNH, SJT)\r\nXPG = (CFJ, KBV)\r\nSVX = (PJR, XMX)\r\nTGR = (TVP, MPG)\r\nNTL = (RRT, MKB)\r\nMKK = (FRD, MCS)\r\nLVL = (LBV, TVZ)\r\nSKT = (FCX, DQC)\r\nNKR = (JTS, FLC)\r\nXFP = (TTK, GLQ)\r\nQGN = (MTG, QVL)\r\nJXD = (MHK, JSS)\r\nPQK = (SVP, QVR)\r\nVBJ = (SSX, HLV)\r\nTDH = (LJQ, DLN)\r\nMRK = (GGX, PGH)\r\nHCB = (HST, GJF)\r\nNSM = (LMH, JTK)\r\nLQG = (TNP, SHH)\r\nPMT = (KLV, JVZ)\r\nCNF = (CJN, VSG)\r\nGGS = (VHV, QQF)\r\nQKM = (BRH, BTJ)\r\nKRN = (DTH, HFG)\r\nTKV = (RXM, PHM)\r\nGKB = (FNX, QHB)\r\nGNH = (PMJ, LDH)\r\nRCZ = (FGM, MRQ)\r\nHFP = (KSN, RKG)\r\nJLX = (DQC, FCX)\r\nCMS = (LVR, VMJ)\r\nRXM = (QXX, LJR)\r\nTRH = (HGR, FPB)\r\nTPR = (JBC, KHX)\r\nMCS = (XPG, GDL)\r\nGKT = (MKN, KPX)\r\nRKG = (VDX, SVM)\r\nBDB = (MCF, SFK)\r\nTLG = (HGG, DCX)\r\nKLG = (QQF, VHV)\r\nRVR = (GDB, NGV)\r\nJBC = (GPG, KSS)\r\nBVS = (BHQ, PNX)\r\nDLQ = (SGS, LFP)\r\nBNL = (GFC, MCP)\r\nKNH = (MKN, KPX)\r\nBNV = (LLX, CBT)\r\nGVJ = (JNT, QKQ)\r\nSHH = (KMD, XMB)\r\nBXH = (TRX, FJG)\r\nQBL = (JQH, RFD)\r\nXNF = (TPR, NHG)\r\nTKG = (KSM, JKC)\r\nPLN = (VGM, JNC)\r\nPRB = (RCX, MQJ)\r\nCVP = (VFL, KHL)\r\nXLM = (TSC, GGN)\r\nQPT = (SRM, QTT)\r\nBQH = (QVR, SVP)\r\nBMB = (FGK, BXH)\r\nCRR = (LVT, DDV)\r\nSXM = (NDD, NTG)\r\nSGR = (NHJ, LQG)\r\nSRM = (HLR, STJ)\r\nCLT = (TGN, TMP)\r\nFFQ = (SRD, BDR)\r\nNBF = (TQC, SQQ)\r\nJBK = (LBB, LBB)\r\nPXM = (GBX, LMD)\r\nVNX = (GKR, HQT)\r\nDLN = (VXC, SNP)\r\nXNL = (KCB, LHC)\r\nQJH = (HNH, VFH)\r\nBGT = (DGX, MGN)\r\nQSL = (VVQ, QCT)\r\nBPL = (VMM, FKD)\r\nVKC = (SGR, RJD)\r\nTHR = (HDJ, NQN)\r\nKFD = (JNP, TQH)\r\nXMN = (NBF, FXF)\r\nMXH = (LFP, SGS)\r\nDRP = (TKV, QFG)\r\nCMM = (MHK, JSS)\r\nRCM = (TXL, MKX)\r\nJLF = (CBT, LLX)\r\nXGN = (VSS, VRT)\r\nKCH = (FSR, GVJ)\r\nLPB = (NBF, FXF)\r\nMQC = (SFM, LFG)\r\nJGQ = (KQG, GDQ)\r\nVVQ = (MNH, BNL)\r\nBDR = (DXH, DPG)\r\nGGN = (DNQ, FFK)\r\nTGA = (FRS, HFP)\r\nVLT = (DXD, GPN)\r\nLFB = (CXL, RRF)\r\nKVD = (CSD, BTG)\r\nFJV = (DGP, HMV)\r\nHFG = (GGV, QKK)\r\nCBB = (PLT, RPJ)\r\nLDT = (PLP, PPH)\r\nBJG = (TBK, DPT)\r\nNFM = (HRK, XQR)\r\nQBX = (KHL, VFL)\r\nJNV = (XGN, GFN)\r\nVSS = (DCV, NHB)\r\nBRH = (FKB, QTL)\r\nSSF = (VQR, XJB)\r\nRDP = (NQM, THR)\r\nPQM = (TPD, NDN)\r\nJST = (RHD, LVL)\r\nNCH = (KPT, BBK)\r\nVFL = (PRB, SCN)\r\nHQQ = (JPM, LKS)\r\nJTK = (NVT, FJV)\r\nNVT = (DGP, HMV)\r\nFNX = (NNS, NNS)\r\nGSG = (XLL, HMC)\r\nSQQ = (THB, DRD)\r\nKMG = (GQV, PQM)\r\nKDJ = (CHN, NHX)\r\nMQD = (MJJ, CGL)\r\nTVZ = (KHB, FFL)\r\nJGX = (MCK, TXT)\r\nCNS = (JLT, DVR)\r\nJBH = (RTB, FFQ)\r\nGGX = (PVM, XXK)\r\nTGN = (JVK, PQF)\r\nJNX = (VKS, PRF)\r\nTLC = (PLP, PPH)\r\nTQH = (GSM, CMS)\r\nKHK = (TRQ, JCS)\r\nKMZ = (VNR, XLR)\r\nSFK = (TSH, VJM)\r\nKTT = (TFL, TPL)\r\nMVV = (NBL, CBX)\r\nLVR = (NCH, SGM)\r\nBDK = (THX, PXM)\r\nHRN = (QQC, QQC)\r\nLFR = (CNS, LBC)\r\nCHN = (QLV, HPT)\r\nRHH = (PPJ, RHX)\r\nXJB = (JBK, RMR)\r\nFXC = (KMQ, FNN)\r\nRQC = (XXS, LGS)\r\nCGL = (RTK, LVN)\r\nSQV = (FRV, QNP)\r\nGXN = (RRF, CXL)\r\nFPR = (XDB, PTF)\r\nDDV = (VCB, MKK)\r\nBTC = (PQK, BQH)\r\nGDP = (MBH, FFP)\r\nPDF = (GJF, HST)\r\nSQM = (QFG, TKV)\r\nVLC = (MBH, FFP)\r\nPJS = (RDP, STC)\r\nRFM = (RVL, BTC)\r\nPTF = (TSB, NSM)\r\nMCF = (VJM, TSH)\r\nKCX = (HNH, VFH)\r\nGHV = (TJC, QPK)\r\nDDN = (QBF, CLT)\r\nDFR = (XKR, HNP)\r\nSXR = (XCH, SQV)\r\nGLQ = (KJM, CKR)\r\nDNJ = (SXR, XKT)\r\nQHD = (QBL, NKN)\r\nNHB = (VPR, KVD)\r\nSDR = (GVJ, FSR)\r\nCRK = (JGX, QKD)\r\nSJR = (HXV, LMC)\r\nFQC = (VKS, PRF)\r\nSLT = (XCF, HNX)\r\nQTF = (TQH, JNP)\r\nVMX = (LGN, CCH)\r\nQFS = (STC, RDP)\r\nFCX = (QSL, DJF)\r\nDFS = (VLC, GDP)\r\nLHC = (TNR, HMK)\r\nHBQ = (KCH, SDR)\r\nTRT = (QPT, QLG)\r\nQLV = (FJQ, BVS)\r\nFKB = (NGG, VLT)\r\nHST = (KTS, LCH)\r\nBBK = (BVJ, BNM)\r\nJQX = (SPK, MFB)\r\nTBK = (SKJ, TDH)\r\nCSD = (SDC, TNQ)\r\nSHN = (QPK, TJC)\r\nHQT = (NPV, CTP)\r\nTJC = (KXM, JBH)\r\nFDP = (FVR, HHX)\r\nQDR = (BFT, QGP)\r\nAAA = (MHM, LFM)\r\nGTD = (JXM, KMZ)\r\nTRN = (LTJ, FTV)\r\nTMF = (QGN, FTS)\r\nLVQ = (MRK, JHM)\r\nPNX = (XMN, LPB)\r\nKCB = (TNR, HMK)\r\nFJQ = (PNX, BHQ)\r\nTGB = (LGS, XXS)\r\nSSP = (QRR, MRZ)\r\nGGG = (BMB, NFQ)\r\nFNH = (STQ, JKL)\r\nLFD = (SJT, FNH)\r\nLLX = (JHS, GQC)\r\nBQS = (QPT, QLG)\r\nQJK = (RHK, VFQ)\r\nSBK = (MBM, DTT)\r\nQVL = (QHV, CMB)\r\nQQC = (GQQ, GQQ)\r\nHNX = (DNJ, XCP)\r\nBXM = (QSJ, BLR)\r\nTNR = (VNX, XRC)\r\nSHR = (XRP, JCX)\r\nVGM = (BQS, TRT)\r\nBSR = (VVT, GNH)\r\nLCH = (RJC, NKH)\r\nFVT = (SKT, JLX)\r\nHGG = (KNH, GKT)\r\nHVF = (XVP, HQR)\r\nJSS = (SBK, XGH)\r\nTKF = (VSG, CJN)\r\nXCF = (XCP, DNJ)\r\nMCK = (RTL, KRN)\r\nDGP = (LDT, TLC)\r\nFSR = (JNT, QKQ)\r\nJCX = (KTT, BKX)\r\nMGN = (PDF, HCB)\r\nBQC = (BLR, QSJ)\r\nKMD = (NPR, NDP)\r\nQCK = (XBX, TBS)\r\nGFC = (HCQ, SHT)\r\nJXM = (XLR, VNR)\r\nXKT = (XCH, SQV)\r\nTHN = (SGV, JDB)\r\nXCP = (SXR, XKT)\r\nNHG = (JBC, KHX)\r\nHXP = (PPJ, RHX)\r\nNHJ = (TNP, SHH)\r\nQTL = (NGG, VLT)\r\nXVP = (SVC, SVC)\r\nFNR = (GVN, SVX)\r\nMDN = (MVV, DRB)\r\nLTR = (RRT, MKB)\r\nKSS = (BGT, MNM)\r\nSBV = (HLV, SSX)\r\nMXN = (PJB, XLM)\r\nMTG = (QHV, CMB)\r\nMLT = (TDJ, XNL)\r\nTSC = (DNQ, FFK)\r\nVCB = (FRD, MCS)\r\nCNT = (HGG, DCX)\r\nSSQ = (XVP, HQR)\r\nXKR = (VRM, DHN)\r\nBLK = (QBD, SSF)\r\nHPJ = (BDQ, QQK)\r\nJPM = (NNN, HPJ)\r\nKPH = (XNF, TXM)\r\nLDS = (GMG, ZZZ)\r\nLQN = (GQQ, PMT)\r\nHRK = (BJG, GMN)\r\nBGH = (KCV, FXP)\r\nBVJ = (SXK, SXM)\r\nGDB = (PSL, QBH)\r\nGPN = (BKS, DFX)\r\nRTL = (HFG, DTH)\r\nTMM = (KFD, QTF)\r\nGSK = (HRN, VKG)\r\nVKG = (QQC, LQN)\r\nRMX = (BDK, MCM)\r\nCBT = (GQC, JHS)\r\nRHD = (LBV, LBV)\r\nNMP = (GXQ, HLL)\r\nMRZ = (DMP, TJT)\r\nXMR = (SFM, LFG)\r\nQBH = (TCM, XMQ)\r\nPMJ = (FDP, QBR)\r\nQKQ = (MQC, XMR)\r\nJDB = (BCL, GTD)\r\nRCX = (VMR, TXX)\r\nLJR = (TMF, PNB)\r\nJVZ = (HFP, FRS)\r\nDRD = (JGQ, QDQ)\r\nSVM = (NPS, SMD)\r\nFTV = (KGH, QTD)\r\nQDH = (QRR, QRR)\r\nBCP = (RCV, NFM)\r\nDCT = (KFD, QTF)\r\nPVM = (JVR, FSF)\r\nSGM = (BBK, KPT)\r\nGQQ = (KLV, KLV)\r\nPJR = (RMN, JTD)\r\nVKS = (TKF, CNF)\r\nNKS = (DRP, SQM)\r\nJQS = (FSP, GLG)\r\nRRH = (LKS, JPM)\r\nSJG = (QBD, SSF)\r\nQSR = (NHX, CHN)\r\nSCN = (RCX, MQJ)\r\nNQS = (XBX, TBS)\r\nGLG = (LXP, RKL)\r\nQTD = (RCM, KVH)\r\nXFT = (TXM, XNF)\r\nDTH = (GGV, QKK)\r\nFSP = (LXP, RKL)\r\nJVK = (HBK, RMP)\r\nSPK = (CFL, PBB)\r\nNQF = (NFQ, BMB)\r\nKQV = (CJS, RVR)\r\nSGQ = (TGR, CXH)\r\nDXD = (BKS, DFX)\r\nKGH = (RCM, KVH)\r\nLBB = (RHD, RHD)\r\nRHX = (XVR, QTS)\r\nJHS = (SJR, CLL)\r\nSGC = (LFB, GXN)\r\nRQJ = (FNX, FNX)\r\nSHT = (QXF, MDN)\r\nTHB = (JGQ, QDQ)\r\nRMR = (LBB, JST)\r\nRDM = (LHL, THF)\r\nJTS = (SSQ, HVF)\r\nRPJ = (FRP, MTF)\r\nQCT = (MNH, BNL)\r\nXLR = (TKS, LQR)\r\nVRT = (NHB, DCV)\r\nLDH = (FDP, QBR)\r\nSNP = (MLQ, LNT)\r\nFKR = (GLG, FSP)\r\nQLG = (QTT, SRM)\r\nVXB = (RPJ, PLT)\r\nLFP = (TGB, RQC)\r\nNDN = (LFR, SPS)\r\nTXT = (KRN, RTL)\r\nNSL = (HJT, TFN)\r\nQQK = (BCP, LNN)\r\nCJN = (MNF, LFD)\r\nPNB = (QGN, FTS)\r\nSPS = (CNS, LBC)\r\nXMB = (NPR, NDP)\r\nVJM = (LDP, QMD)\r\nMRQ = (SJQ, NDQ)\r\nMCH = (VLC, GDP)\r\nKLV = (FRS, HFP)\r\nHDJ = (DDR, RMX)\r\nLMH = (FJV, NVT)\r\nPTB = (QBF, CLT)\r\nMVD = (KSM, JKC)\r\nVXF = (KCV, FXP)\r\nHXV = (CRR, XLC)\r\nQJJ = (GSG, CQB)\r\nVMR = (DMS, DFR)\r\nTJT = (SDM, VKK)\r\nLNJ = (JLF, BNV)\r\nSVC = (QDH, QDH)\r\nVSG = (MNF, LFD)\r\nBFT = (DLQ, MXH)\r\nRJC = (KXH, DNV)\r\nFRV = (RQR, XPH)\r\nBNM = (SXK, SXM)\r\nLFM = (SLG, JQX)\r\nMSK = (CCH, LGN)\r\nJNT = (MQC, XMR)\r\nDHN = (LXC, QJJ)\r\nQTT = (STJ, HLR)\r\nQDP = (CVP, QBX)\r\nHPN = (THM, LDS)\r\nHNP = (DHN, VRM)\r\nNKH = (DNV, KXH)\r\nVHV = (HBQ, CND)\r\nCJF = (FKD, VMM)\r\nMKX = (VJS, RDM)\r\nCHD = (LFB, GXN)\r\nBKX = (TFL, TPL)\r\nDCG = (KTH, LXS)\r\nLTJ = (QTD, KGH)\r\nPQA = (FFL, KHB)\r\nGKR = (CTP, NPV)\r\nDSP = (QJP, GBK)\r\nXRC = (HQT, GKR)\r\nFJG = (PJS, QFS)\r\nXCC = (SJG, BLK)\r\nLKS = (HPJ, NNN)\r\nDPG = (NLX, KQV)\r\nPSL = (XMQ, TCM)\r\nNGV = (QBH, PSL)\r\nRMN = (GHT, BQP)\r\nNQM = (NQN, HDJ)\r\nCQB = (HMC, XLL)\r\nQJV = (RJD, SGR)\r\nMNM = (DGX, MGN)\r\nVQR = (JBK, RMR)\r\nXCH = (QNP, FRV)\r\nHCQ = (MDN, QXF)\r\nHJT = (RPB, JTM)\r\nVMJ = (SGM, NCH)\r\nDNV = (FPR, GTC)\r\nLGN = (JGS, MTJ)\r\nTQC = (DRD, THB)\r\nJFQ = (LTJ, FTV)\r\nJGS = (BDB, KKQ)\r\nRKL = (NVL, LNJ)\r\nCLR = (DSP, MXS)\r\nCQA = (MRQ, FGM)\r\nHQR = (SVC, JLD)\r\nDMP = (VKK, SDM)\r\nQSJ = (NTL, LTR)\r\nGDL = (KBV, CFJ)\r\nFTS = (MTG, QVL)\r\nDCV = (KVD, VPR)\r\nTRX = (PJS, QFS)\r\nKTK = (PJB, XLM)\r\nXMJ = (TTH, BSR)\r\nHBK = (MLT, XMV)\r\nCHL = (JNC, VGM)\r\nQQF = (CND, HBQ)\r\nDFX = (SLX, XCC)\r\nLJQ = (VXC, SNP)\r\nTXM = (NHG, TPR)\r\nNHX = (HPT, QLV)\r\nGJF = (KTS, LCH)\r\nLNN = (NFM, RCV)\r\nDXH = (NLX, KQV)\r\nSXK = (NTG, NDD)\r\nCXH = (MPG, TVP)\r\nPHM = (LJR, QXX)\r\nCND = (KCH, SDR)\r\nMSG = (CBH, NKS)\r\nRQR = (SXH, BVX)\r\nGHT = (QQL, BVH)\r\nGTK = (VFQ, RHK)\r\nNDQ = (NQF, GGG)\r\nCVC = (SGV, SGV)\r\nNGG = (GPN, DXD)\r\nPBB = (CLR, GTN)\r\nJLT = (QSR, KDJ)\r\nMBH = (JNV, QPG)\r\nJTD = (GHT, BQP)\r\nLBV = (FFL, KHB)\r\nXXS = (VXF, BGH)\r\nGMH = (GGS, KLG)";

            var lines = input.Replace("\r\n", "\n").Split('\n');

            string instr = lines[0];
            var nodes = new Dictionary<string, (string, string)>();

            for (int i = 2; i < lines.Length; i++)
            {
                string line = lines[i];
                nodes.Add(line.Substring(0, 3), (line.Substring(7, 3), line.Substring(12, 3)));

            }

            //var current = "AAA";
            var zs = new List<long>();
            var currents = nodes.Keys.Where(x => x.EndsWith("A"));
            foreach (var current in currents)
            {
                zs.Add(GetZ(current, instr, nodes));
            }

            Console.WriteLine(LeastCommonMultiple(zs));
        }

        static long LeastCommonMultiple(IEnumerable<long> numbers)
        {
            return numbers.Aggregate(LeastCommonMultiple);
        }
        static long LeastCommonMultiple(long a, long b)
        {
            return Math.Abs(a * b) / GreatestCommonDivisor(a, b);
        }
        static long GreatestCommonDivisor(long a, long b)
        {
            return b == 0 ? a : GreatestCommonDivisor(b, a % b);
        }

        private static long GetZ(string current, string instr, Dictionary<string, (string, string)> nodes)
        {
            long j = 0;
            while (!current.EndsWith("Z"))
            {
                if (instr[(int)(j % instr.Length)] == 'L')
                {
                    current = nodes[current].Item1;
                }
                else
                {
                    current = nodes[current].Item2;
                }
                j++;
            }

            return j;
        }
    }
}