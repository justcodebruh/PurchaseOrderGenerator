namespace EdiFabric.Templates.X12004010
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using System.Xml.Serialization;
    
    
    [Serializable()]
    [DataContract()]
    public class X12_AN
    {
    }
    
    [Serializable()]
    [DataContract()]
    public class X12_DT
    {
    }
    
    /// <summary>
    /// Percent Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,05,06,07,08,09,1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,3,30,31,32,33,34,35,36,37,38,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AP,AR,AT,B,BA,BB,BC,BD,BE,BF,BG,BH,BP,BS,BU,C,CA,CB,CH,CJ,CN,CO,CP,CR,CS,CU,D,DF,DY,E,EA,EF,EP,F,FT,FV,GA,IA,IN,KA,KB,LM,M,MA,MN,MS,MX,N,NA,NH,O,OC,OF,OH,OP,P,PA,PC,PD,PF,PH,PM,PN,PP,PR,PT,PV,R,RA,RB,RC,RD,RF,RG,RI,RL,RO,RP,RQ,RR,RS,S,SA,SC,SD,SE,SF,SG,T,TP,W,WI,WK,X,X1,XT,")]
    public class X12_ID_1004
    {
    }
    
    /// <summary>
    /// Hierarchical Structure Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",0001,0002,0003,0004,0010,0011,0012,0013,0014,0015,0016,0017,0018,0019,0020,0021,0022,0023,0035,0036,0055,0056,0057,0058,0059,0060,0061,0062,0063,0064,0065,0066,0067,0068,0069,0070,0071,0072,0073,0074,0075,0076,0077,0078,0079,0080,0081,0082,0083,0200,0201,0202,0203,0204,0205,0206,0207,0208,0209,0210,ZZZZ,")]
    public class X12_ID_1005
    {
    }
    
    /// <summary>
    /// Invoice Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",IBM,IEL,INR,")]
    public class X12_ID_1019
    {
    }
    
    /// <summary>
    /// Ownership Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",L,N,R,S,T,")]
    public class X12_ID_102
    {
    }
    
    /// <summary>
    /// Citizenship Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,")]
    public class X12_ID_1066
    {
    }
    
    /// <summary>
    /// Marital Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,I,K,M,R,S,U,W,X,")]
    public class X12_ID_1067
    {
    }
    
    /// <summary>
    /// Gender Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,F,M,N,U,X,")]
    public class X12_ID_1068
    {
    }
    
    /// <summary>
    /// Payment Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,8,A,AA,AB,AC,AD,AE,AF,AG,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y" +
        ",")]
    public class X12_ID_107
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,U,W,Y,")]
    public class X12_ID_1073
    {
    }
    
    /// <summary>
    /// Address Component Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,51,52,53,54,56,57,58,59,60,61,62,63,6" +
        "4,65,66,67,68,69,71,74,79,80,90,91,92,93,94,96,97,")]
    public class X12_ID_1106
    {
    }
    
    /// <summary>
    /// Race or Ethnicity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",7,8,A,B,C,D,E,F,G,H,I,J,N,O,P,Z,")]
    public class X12_ID_1109
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,DA,DB,DC,DD,DE,DF,DG,DH,DI,DP,DR,DV,E1,E2,E3,E4,E5,EB,EC,ED,EE,EF,EG,EH,EI,EJ,FA,FC,FH,FI,FP,FR,FT,GD,GS,GU,HA,HB,HC,HD,HE,HF,HG,HH,HI,HJ,HK,HL,HM,HN,HO,HP,HQ,HR,HS,HT,HY,HZ,IC,ID,IH,IM,IN,LA,LE,LL,LR,LS,LT,LZ,MA,MI,MN,MO,MP,MS,MT,NC,NS,NW,OA,OC,OF,ON,OP,OT,OU,PA,PB,PC,PD,PE,PF,PG,PI,PN,PO,PR,PS,PT,R1,R2,R3,R4,R5,RC,RE,RI,RL,RM,RN,RR,RS,RT,RU,RV,SA,SD,SE,SI,SJ,SL,SN,SP,SR,SS,ST,SU,SW,SZ,TB,TE,TF,TH,TI,TM,TN,TP,TR,TW,UP,VA,VC,VD,VO,WA,WM,ZZ,")]
    public class X12_ID_1136
    {
    }
    
    /// <summary>
    /// Port or Terminal Function Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,V,W,Y,")]
    public class X12_ID_115
    {
    }
    
    /// <summary>
    /// Contract Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,09,AB,AC,AD,AE,AF,AG,AH,AI,AJ,CA,CB,CH,CP,CS,CW,CX,CY,DI,EA,ER" +
        ",FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ,FK,FL,FM,FR,FX,LA,LE,LH,OC,PR,SP,TM,ZZ,")]
    public class X12_ID_1166
    {
    }
    
    /// <summary>
    /// Customs Entry Type Group Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,W,")]
    public class X12_ID_1179
    {
    }
    
    /// <summary>
    /// Breakdown Structure Detail Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,70,71,72,73,74,75,77,78,79,80,81,82,83,84,85,86,87,88,A1,A2,A3,A4,A5,A6,A7,A8,A9,AT,B1,B2,B3,B4,B5,BL,BY,C1,C2,C3,C4,CM,CY,D1,D2,D3,D4,D5,D6,D7,E1,E2,E3,E4,EH,ES,EX,F1,F2,F3,F4,FE,FP,FR,G1,G2,G3,G4,G5,H1,H2,H3,H4,H5,I1,IN,J1,J2,K6,L1,LM,M1,MD,MR,N1,NP,P1,P2,P3,P4,P5,P6,RL,SC,TA,TC,TD,TR,TU,UB,ZZ,")]
    public class X12_ID_1196
    {
    }
    
    /// <summary>
    /// Purchase Category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AE,CN,DR,ER,HW,IR,MD,OV,RD,RE,SB,SP,SU,SV,TE,UT,")]
    public class X12_ID_1232
    {
    }
    
    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CC,CD,CM,CQ,CY,D6,D8,DA,DB,DD,DT,DTS,EH,KA,MD,MM,RD,RD2,RD4,RD5,RD6,RD8,RDM,RDT," +
        "RMD,RMY,RTM,RTS,TC,TM,TQ,TR,TS,TT,TU,UN,YM,YMM,YY,")]
    public class X12_ID_1250
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,10,100,101,102,103,104,105,106,107,108,109,11,12,13,14,16,17,19,2,20,21,22,2" +
        "3,24,25,26,27,28,29,3,30,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49" +
        ",5,52,53,54,55,56,57,58,59,6,60,61,62,63,66,67,69,7,71,74,75,78,79,8,80,81,82,83" +
        ",84,85,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA," +
        "AAA,AB,ABR,ABS,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,ALP,AM,AN,AO,AP,APE,AQ,AR,AS,AT,AU," +
        "AW,AX,B,BA,BB,BC,BCC,BCR,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BPL,BQ,BR,BRL,BS" +
        ",BSL,BU,BV,BY,BZ,C,C1,C2,C3,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CLP,CM,CML,CN,CO" +
        ",COG,CPS,CRC,CS,CSF,CT,CU,CV,CW,CZ,D,D1,D2,D3,D4,D5,DA,DB,DBS,DC,DD,DE,DF,DG,DGO" +
        ",DH,DI,DJ,DK,DL,DLO,DLP,DM,DN,DO,DPE,DPL,DQ,DR,DS,DT,DU,DW,DX,DY,DZ,E,EA,EB,EC,E" +
        "D,EE,EF,EG,EH,EI,EJ,EK,EL,EM,EN,EO,EQ,ER,ES,ESL,ET,ETL,EU,EV,EW,EWC,EWR,EX,EY,EZ" +
        ",F,FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ,FK,FL,FM,FN,FO,FP,FQ,FR,FS,FT,FU,FV,FW,FX,FZ,G," +
        "G1,GA,GB,GC,GD,GE,GF,GG,GI,GJ,GK,GQ,GR,GS,GT,GU,GV,GW,H,HA,HB,HD,HE,HI,HRC,HS,HZ" +
        "R,I,IC,ID,IF,IMC,IMP,IPA,IQ,IT,J,J0,J1,J2,J3,J4,J5,J6,J7,J8,J9,JA,JB,JC,JCL,JD,J" +
        "E,JF,JG,JH,JI,JK,JL,JM,JN,JO,JOL,JP,K,KA,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KO," +
        "KP,KQ,KS,KT,KU,KW,KYL,KZ,L,LA,LB,LC,LD,LE,LF,LG,LH,LIN,LJ,LK,LM,LN,LO,LOI,LP,LQ," +
        "LR,LS,LSC,LT,LZ,M,MB,MC,MCC,MCD,ME,MI,MJ,MK,ML,MN,MOC,N,NA,NAC,NAF,NAS,NB,NC,ND," +
        "NDC,NE,NF,NH,NI,NJ,NK,NL,NP,NR,NS,NT,O,O1,O2,O3,O4,OC,P,PB,PC,PD,PGS,PI,PIT,PL,P" +
        "LC,PLS,PPD,PPP,PPS,PPV,PRA,PRC,PRR,PRT,PS,PWA,PWI,PWR,PWS,PWT,Q,QA,QB,QC,QE,QF,Q" +
        "G,QH,QI,QJ,QK,QS,R,RA,RC,RCA,RD,RE,REN,RF,RI,RQ,RR,RT,RTC,RUM,RX,S,SA,SB,SBA,SC," +
        "SD,SE,SEC,SF,SG,SH,SHL,SI,SJ,SL,SM,SMI,SO,SP,SPE,SR,SRL,SS,ST,STC,T,T00,T01,T02," +
        "T03,T04,T05,T06,T07,T08,T09,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,TB,T" +
        "C,TCL,TD,TE,TF,TG,TOL,TR,TTL,TX,TY,U,UP,UR,US,UU,V,W,WDL,X,Y,Z,ZZ,")]
    public class X12_ID_1270
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,0A,0B,0D,0E,0F,0G,0H,0I,0J,0K,0L,0M,0N,0P,10,11,12,13" +
        ",14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H,1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1S,1T,1" +
        "U,1V,1W,1X,1Y,1Z,20,21,22,23,24,25,26,27,28,29,2A,2B,2C,2D,2E,2F,2G,2H,2I,2J,2K," +
        "2L,2M,2N,2O,2P,2Q,2R,2S,2T,2U,2V,2W,2X,2Y,2Z,30,31,32,33,34,35,36,37,38,39,3A,3B" +
        ",3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R,3S,3T,3U,3V,3W,3X,3Y,3Z,40,41,4" +
        "2,43,44,45,46,47,48,49,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4K,4L,4M,4N,4O,4P,4Q,4R,4S," +
        "4T,4U,4V,4W,4X,4Y,4Z,50,51,52,53,54,55,56,57,58,59,5A,5B,5C,5D,5E,5F,5G,5H,5I,5J" +
        ",5K,5L,5M,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z,60,61,63,64,65,66,67,68,69,6A,6" +
        "B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R,6S,6T,6U,6V,6W,6X,6Y,6Z,70,71," +
        "72,73,74,75,76,77,78,79,7A,7B,7C,7D,7E,7F,7G,7H,7I,7J,7K,7L,7M,7N,7O,7P,7Q,7R,7S" +
        ",7T,7U,7W,7X,7Y,7Z,80,81,82,83,84,85,86,87,88,89,8A,8B,8C,8D,8E,8F,8G,8H,8I,8J,8" +
        "K,8L,8M,8N,8O,8P,8Q,8R,8S,8U,8V,8W,8X,8Y,8Z,90,91,92,93,94,95,96,97,98,99,9A,9B," +
        "9C,9D,9E,9F,9G,9H,9I,9J,9K,9L,9M,9N,9P,9Q,9R,9S,9T,9U,9V,9W,9X,9Y,9Z,A0,A1,A2,A3" +
        ",A4,A5,A6,A7,A8,A9,AA,AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AA" +
        "O,AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AAZ,AB,ABA,ABB,ABC,ABD,ABE,ABF,ABG,ABH" +
        ",ABJ,ABK,ABL,ABM,ABN,ABO,ABP,ABQ,ABR,ABS,ABT,ABU,ABV,ABY,AC,ACA,ACB,ACC,ACD,ACE," +
        "ACF,ACG,ACH,ACI,ACJ,ACK,ACR,ACS,ACT,AD,ADA,ADB,ADC,ADD,ADE,ADF,ADG,ADH,ADI,ADM,A" +
        "E,AEA,AEB,AEC,AED,AEE,AEF,AEG,AEH,AEI,AEJ,AEK,AEL,AEM,AF,AG,AH,AHC,AI,AJ,AK,AL,A" +
        "LC,ALG,ALH,ALI,ALJ,ALT,AM,AN,AO,AP,API,AQ,AR,AS,ASL,ASP,AST,AT,ATC,AU,AV,AW,AX,A" +
        "Y,AZ,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BAA,BAB,BAC,BAD,BAE,BAF,BAG,BAH,BAI,BB,BC,BCI" +
        ",BD,BE,BF,BG,BH,BI,BJ,BK,BKT,BL,BLT,BM,BMM,BN,BO,BOI,BP,BQ,BR,BS,BT,BU,BV,BW,BX," +
        "BY,BZ,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CBG,CC,CD,CDN,CE,CF,CG,CH,CI,CIR,CIT,C" +
        "J,CK,CL,CM,CMN,CMP,CMT,CN,CNO,CO,COL,COT,CP,CPA,CPT,CQ,CR,CRN,CRS,CS,CSC,CSG,CST" +
        ",CT,CTS,CU,CV,CW,CX,CY,CYC,CZ,D0,D1,D2,D3,D4,D5,D6,D7,D8,D9,DA,DB,DC,DD,DE,DF,DG" +
        ",DH,DHH,DI,DIS,DJ,DK,DL,DM,DN,DNR,DNS,DO,DOA,DOC,DOE,DOI,DOJ,DOL,DON,DOS,DOT,DP," +
        "DQ,DR,DRN,DS,DSC,DSI,DST,DT,DTS,DU,DUN,DV,DW,DX,DY,DZ,E1,E2,E3,E4,E5,E6,E7,E8,E9" +
        ",EA,EB,EC,ED,EDA,EE,EF,EG,EH,EI,EJ,EK,EL,EM,EMM,EN,END,EO,EP,EPA,EPB,EQ,ER,ES,ES" +
        "N,ET,EU,EV,EW,EX,EY,EZ,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA,FB,FC,FCN,FD,FE,FF,FG,FH,FI" +
        ",FJ,FK,FL,FLZ,FM,FMP,FN,FND,FO,FP,FQ,FR,FS,FSN,FT,FTN,FU,FV,FW,FWC,FX,FY,FZ,G1,G" +
        "2,G3,G4,G5,G6,G7,G8,G9,GA,GB,GC,GD,GE,GF,GG,GH,GI,GJ,GK,GL,GM,GN,GO,GP,GQ,GR,GS," +
        "GT,GU,GV,GW,GWS,GX,GY,GZ,H1,H2,H3,H4,H5,H6,H7,H8,H9,HA,HB,HC,HD,HE,HF,HG,HH,HHT," +
        "HI,HJ,HK,HL,HM,HMB,HN,HO,HP,HPI,HQ,HR,HS,HT,HU,HUD,HV,HW,HX,HY,HZ,I1,I2,I3,I4,I5" +
        ",I7,I8,I9,IA,IB,IC,ICD,ID,IE,IF,IFT,IG,IH,II,IID,IJ,IK,IL,IM,IMP,IMS,IN,IND,IO,I" +
        "P,IQ,IR,IRN,IRP,IS,ISC,ISN,ISS,IT,IU,IV,IW,IX,IZ,J0,J1,J2,J3,J4,J5,J6,J7,J8,J9,J" +
        "A,JB,JC,JD,JE,JF,JH,JI,JK,JL,JM,JN,JO,JP,JQ,JR,JS,JT,JU,JV,JW,JX,JY,JZ,K0,K1,K2," +
        "K3,K4,K5,K6,K7,K8,K9,KA,KB,KC,KD,KE,KG,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS,KT,KU" +
        ",KV,KW,KX,KY,KZ,L1,L2,L3,L4,L5,L6,L7,L8,L9,LA,LB,LC,LD,LE,LEN,LF,LG,LH,LI,LIC,LJ" +
        ",LK,LL,LM,LN,LO,LOI,LP,LQ,LR,LS,LSD,LT,LU,LV,LVO,LW,LX,LY,LZ,M1,M2,M3,M5,M6,M7,M" +
        "8,M9,MA,MB,MBX,MC,MCI,MD,MDN,ME,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MSL,MT" +
        ",MU,MV,MW,MX,MY,MZ,MZO,N0,N1,N2,N3,N4,N5,N6,N7,N8,N9,NA,NAS,NB,NC,ND,NDA,NDB,NE," +
        "NF,NFC,NFD,NFM,NFN,NFS,NG,NH,NI,NJ,NK,NL,NM,NN,NO,NP,NQ,NR,NS,NT,NU,NW,NX,NY,NZ," +
        "O1,O2,O5,O7,O8,O9,OA,OB,OC,OD,OE,OF,OG,OH,OI,OJ,OK,OL,OM,ON,OP,OQ,OR,OS,OT,OU,OV" +
        ",OW,OX,OZ,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PAC,PAN,PAP,PB,PC,PCC,PCN,PD,PDL,PE,PF,P" +
        "G,PGC,PGN,PGS,PH,PHC,PI,PID,PIN,PJ,PK,PL,PLA,PLN,PM,PMN,PN,PNN,PO,POL,PP,PQ,PR,P" +
        "RS,PRT,PS,PSI,PSL,PSM,PSN,PT,PTC,PU,PV,PW,PWC,PWS,PX,PY,PZ,Q1,Q2,Q3,Q4,Q5,Q6,Q7," +
        "Q8,Q9,QA,QB,QC,QD,QE,QF,QG,QH,QI,QJ,QK,QL,QM,QN,QO,QP,QQ,QR,QS,QT,QU,QV,QW,QX,QY" +
        ",QZ,R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RAA,RAN,RB,RC,RD,RE,REC,RF,RG,RGI,RH,RI,RIG" +
        ",RJ,RK,RL,RM,RN,RO,RP,RPP,RPT,RQ,RR,RRS,RS,RSN,RT,RU,RV,RW,RX,RY,RZ,S0,S1,S2,S3," +
        "S4,S5,S6,S7,S8,S9,SA,SB,SBN,SC,SCA,SD,SE,SEK,SES,SF,SG,SH,SHL,SI,SJ,SK,SL,SM,SN," +
        "SNH,SNV,SO,SP,SPL,SPN,SQ,SR,SS,ST,STB,STR,SU,SUB,SUO,SV,SW,SX,SY,SZ,T0,T1,T2,T3," +
        "T4,T5,T6,T7,T8,T9,TA,TB,TC,TD,TDT,TE,TF,TG,TH,TI,TIP,TJ,TK,TL,TM,TN,TO,TOC,TP,TP" +
        "N,TQ,TR,TS,TSN,TT,TU,TV,TW,TX,TY,TZ,U0,U1,U2,U3,U4,U5,U6,U8,U9,UA,UB,UC,UD,UE,UF" +
        ",UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,UR,URL,US,UT,UU,UV,UW,UX,UY,UZ,V0,V1,V2,V3,V4," +
        "V5,V6,V7,V8,V9,VA,VB,VC,VD,VE,VF,VG,VH,VI,VJ,VK,VL,VM,VN,VO,VP,VQ,VR,VS,VT,VU,VV" +
        ",VW,VX,VY,VZ,W1,W2,W3,W4,W5,W6,W7,W8,W9,WA,WB,WC,WCS,WD,WDR,WE,WF,WG,WH,WI,WJ,WK" +
        ",WL,WM,WN,WO,WP,WQ,WR,WS,WT,WU,WV,WW,WX,WY,WZ,X0,X1,X2,X3,X4,X5,X6,X7,X8,X9,XA,X" +
        "B,XC,XD,XE,XF,XG,XH,XI,XJ,XK,XL,XM,XN,XO,XP,XQ,XR,XS,XT,XU,XV,XW,XX,XY,XZ,Y0,Y1," +
        "Y2,Y3,Y4,Y5,Y6,Y7,Y8,Y9,YA,YB,YC,YD,YE,YF,YH,YI,YJ,YK,YL,YM,YN,YO,YP,YQ,YR,YS,YT" +
        ",YV,YW,YX,YY,YZ,Z1,Z2,Z3,Z4,Z5,Z6,Z7,Z8,Z9,ZA,ZB,ZC,ZD,ZE,ZF,ZG,ZH,ZI,ZJ,ZK,ZL,Z" +
        "M,ZN,ZO,ZP,ZQ,ZR,ZS,ZT,ZU,ZV,ZW,ZX,ZY,ZZ,")]
    public class X12_ID_128
    {
    }
    
    /// <summary>
    /// Service, Promotion, Allowance, or Charge Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A010,A020,A030,A040,A050,A060,A070,A080,A090,A100,A110,A112,A120,A121,A122,A130," +
        "A140,A150,A160,A170,A172,A180,A190,A200,A210,A220,A230,A240,A250,A260,A270,A280," +
        "A290,A300,A310,A320,A330,A340,A350,A360,A370,A380,A390,A400,A410,A420,A430,A440," +
        "A445,A450,A460,A470,A480,A485,A490,A500,A510,A520,A530,A540,A550,A555,A560,A570," +
        "A580,A590,A600,A610,A620,A630,A640,A650,A658,A660,A670,A680,A690,A691,A700,A710," +
        "A720,A721,A730,A740,A750,A760,A770,A780,A790,A800,A810,A820,A830,A840,A850,A860," +
        "A870,A880,A890,A900,A910,A920,A930,A940,A950,A960,A970,A980,A990,ADOW,ADRW,AFEE," +
        "ALPT,B000,B010,B015,B020,B030,B040,B050,B060,B070,B080,B090,B091,B100,B110,B120," +
        "B130,B140,B150,B160,B170,B180,B190,B200,B210,B220,B230,B240,B250,B260,B270,B280," +
        "B290,B300,B310,B320,B330,B340,B350,B360,B370,B380,B390,B400,B500,B510,B520,B530," +
        "B540,B550,B551,B560,B570,B580,B581,B590,B600,B610,B620,B630,B650,B660,B670,B680," +
        "B690,B700,B720,B730,B740,B742,B750,B760,B770,B775,B780,B785,B787,B790,B791,B800," +
        "B810,B820,B830,B840,B850,B860,B870,B872,B880,B881,B890,B900,B910,B911,B920,B930," +
        "B940,B950,B960,B970,B980,B990,B992,B994,B996,B998,BU2T,BU4T,BUAT,BURD,C000,C010," +
        "C020,C030,C040,C050,C060,C070,C080,C090,C100,C110,C120,C130,C140,C150,C160,C170," +
        "C180,C190,C200,C210,C220,C230,C231,C240,C250,C260,C270,C280,C290,C300,C310,C320," +
        "C330,C340,C350,C360,C370,C380,C390,C400,C401,C402,C410,C420,C430,C440,C450,C460," +
        "C470,C480,C490,C500,C510,C520,C530,C531,C540,C550,C560,C570,C580,C590,C600,C610," +
        "C630,C640,C650,C660,C670,C675,C680,C690,C700,C710,C720,C730,C740,C750,C760,C770," +
        "C780,C790,C800,C810,C820,C830,C840,C850,C860,C870,C880,C890,C900,C910,C920,C930," +
        "C940,C950,C960,C970,C980,C990,CA2T,CA4T,CFCT,CFLT,CGTT,CLDT,COMM,CRLT,CTLT,CUFT," +
        "D000,D010,D015,D020,D025,D030,D040,D050,D060,D070,D080,D100,D101,D103,D110,D120," +
        "D130,D140,D141,D142,D143,D144,D150,D160,D170,D180,D190,D200,D210,D220,D230,D240," +
        "D242,D244,D246,D250,D260,D270,D280,D290,D292,D300,D301,D310,D320,D330,D340,D350," +
        "D360,D370,D380,D390,D400,D410,D420,D430,D440,D450,D460,D470,D480,D490,D500,D501," +
        "D502,D510,D520,D530,D540,D550,D560,D570,D580,D590,D600,D610,D620,D630,D640,D650," +
        "D655,D660,D670,D680,D690,D700,D701,D710,D711,D720,D730,D740,D750,D760,D770,D780," +
        "D790,D800,D810,D820,D830,D840,D850,D860,D870,D880,D890,D900,D910,D920,D930,D940," +
        "D950,D960,D970,D980,D990,D995,DCET,DCVT,DDZT,DEZT,DFDT,DGET,DOVT,DPDT,DPET,E000," +
        "E010,E020,E022,E030,E040,E050,E060,E063,E065,E067,E068,E069,E070,E080,E090,E100," +
        "E110,E120,E130,E140,E150,E160,E170,E180,E190,E191,E192,E193,E200,E210,E220,E230," +
        "E240,E250,E260,E270,E280,E290,E300,E310,E320,E330,E340,E350,E360,E370,E380,E381," +
        "E382,E384,E386,E388,E389,E390,E400,E410,E420,E430,E440,E450,E460,E470,E480,E485," +
        "E490,E500,E510,E520,E530,E540,E550,E560,E570,E580,E585,E590,E600,E610,E620,E630," +
        "E640,E650,E660,E670,E680,E690,E695,E700,E710,E720,E730,E740,E750,E760,E770,E780," +
        "E790,E800,E805,E810,E820,E830,E840,E850,E860,E870,E880,E890,E900,E910,E920,E930," +
        "E940,E950,E960,E970,E980,E990,ENGA,EXLT,F000,F010,F020,F030,F040,F050,F060,F061," +
        "F062,F063,F065,F067,F070,F080,F090,F100,F110,F120,F130,F140,F150,F155,F160,F170," +
        "F180,F190,F200,F210,F220,F225,F230,F240,F250,F260,F270,F271,F272,F280,F290,F300," +
        "F310,F320,F330,F340,F350,F360,F370,F380,F390,F400,F401,F410,F420,F430,F440,F445," +
        "F450,F460,F465,F470,F480,F490,F500,F510,F520,F530,F540,F550,F560,F570,F580,F590," +
        "F600,F610,F620,F630,F640,F650,F660,F670,F680,F690,F700,F710,F720,F730,F740,F750," +
        "F760,F770,F780,F790,F800,F810,F820,F830,F840,F850,F860,F870,F880,F890,F900,F910," +
        "F920,F930,F940,F950,F960,F970,F980,F990,F991,FAKT,FLST,G000,G010,G020,G025,G030," +
        "G040,G050,G060,G070,G080,G090,G100,G110,G120,G130,G140,G150,G160,G170,G180,G190," +
        "G200,G210,G220,G230,G240,G250,G260,G270,G280,G290,G300,G310,G320,G322,G324,G326," +
        "G328,G329,G330,G340,G350,G360,G370,G380,G390,G400,G410,G420,G430,G440,G450,G460," +
        "G470,G480,G490,G500,G510,G520,G530,G540,G550,G560,G570,G580,G590,G600,G610,G620," +
        "G630,G640,G650,G660,G670,G680,G690,G700,G710,G720,G730,G740,G750,G760,G770,G775," +
        "G780,G790,G800,G810,G820,G821,G830,G840,G850,G860,G870,G880,G890,G900,G910,G920," +
        "G930,G940,G950,G960,G970,G980,G990,GMST,H000,H010,H020,H030,H040,H050,H060,H070," +
        "H080,H090,H100,H110,H120,H130,H140,H150,H151,H160,H170,H180,H190,H200,H210,H215," +
        "H220,H230,H240,H250,H260,H270,H280,H290,H300,H310,H320,H330,H340,H350,H360,H370," +
        "H380,H390,H400,H410,H420,H430,H440,H450,H460,H470,H480,H490,H500,H505,H507,H510," +
        "H520,H530,H535,H540,H550,H551,H560,H570,H580,H590,H600,H605,H610,H620,H625,H630," +
        "H640,H650,H660,H670,H680,H690,H700,H710,H720,H730,H740,H750,H760,H770,H780,H790," +
        "H800,H806,H810,H820,H830,H840,H850,H855,H860,H870,H880,H890,H900,H910,H920,H930," +
        "H935,H940,H950,H960,H970,H980,H990,HZDT,I000,I010,I020,I030,I040,I050,I060,I070," +
        "I080,I090,I100,I110,I120,I130,I131,I132,I133,I134,I136,I138,I140,I150,I160,I170," +
        "I180,I190,I200,I210,I220,I230,I240,I250,I260,I270,I280,I290,I300,I310,I320,I330," +
        "I340,I350,I360,I370,I380,I390,I400,I410,I411,I420,I430,I431,I432,I440,I450,I460," +
        "I470,I480,I490,I495,I500,I510,I520,I530,I540,I550,I560,I570,I580,I590,I595,I600," +
        "I610,I620,I630,I640,I650,I660,I670,I680,I690,I700,I710,I720,I730,I740,I750,I760," +
        "IDCT,LC2T,LC4T,LCLT,LECT,LFDT,LMDT,LNDT,LPDT,LQDT,LTET,MATT,OCNT,OFFA,OODT,OTHR," +
        "OWCT,PRST,PTAX,PVPT,R020,R030,R040,R060,R080,RDHT,RFMT,RPDT,RSTT,SFBT,SFDT,SFET," +
        "SSCT,SSUT,STDT,STFT,STOT,TERT,VCLT,WBBT,WCFT,WFTT,WRBT,WRIT,ZZZZ,")]
    public class X12_ID_1300
    {
    }
    
    /// <summary>
    /// Acquisition Data Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,K1,K2,K3,K4,K5,K6,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS,KT,KU,KV,KW,KX,KY,KZ,L2,")]
    public class X12_ID_1309
    {
    }
    
    /// <summary>
    /// Financing Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,G,P,")]
    public class X12_ID_1310
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H" +
        ",1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,20,21,22,23,24,25,26,27,2" +
        "8,29,2A,2B,2C,2D,2E,2F,2G,2H,2I,2J,2K,2L,2M,2N,2O,2P,2Q,2R,2S,2T,2U,2V,2W,2X,2Y," +
        "2Z,30,31,32,33,34,35,36,37,38,39,3A,3B,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P" +
        ",3Q,3R,3S,3T,3U,3V,3W,3X,3Y,3Z,40,41,42,43,44,45,46,47,48,49,4A,4B,4C,4D,4E,4F,4" +
        "G,4H,4I,4J,4K,4L,4M,4N,4O,4P,4Q,4R,4S,4T,4U,4V,4W,4X,4Y,4Z,50,51,52,53,54,55,56," +
        "57,58,59,5A,5B,5C,5D,5E,5F,5G,5H,5I,5J,5K,5L,5M,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X" +
        ",5Y,5Z,60,61,62,63,64,65,66,67,68,69,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6" +
        "O,6P,6Q,6R,6S,6T,6U,6V,6W,6X,6Y,6Z,70,71,72,73,74,75,76,77,78,79,7A,7B,7C,7D,7E," +
        "7F,7G,7H,7I,7J,7K,7L,7M,7N,7O,7P,7Q,7R,7S,7T,7U,7V,7W,7X,7Y,7Z,80,81,82,83,84,85" +
        ",86,87,88,89,8A,8B,8C,8D,8E,8F,8G,8H,8I,8J,8K,8L,8M,8N,8O,8P,8Q,8R,8S,8T,8U,8V,8" +
        "W,8X,8Y,8Z,90,91,92,93,94,95,96,97,98,99,9A,9B,9C,9D,9E,9F,9G,9H,9I,9J,9K,9L,9M," +
        "9N,9O,9P,9Q,9R,9S,9T,9U,9V,9W,9X,9Y,9Z,A1,A2,A3,A4,A5,A7,A8,A9,AA,AB,AC,AD,AE,AF" +
        ",AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B" +
        "7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX," +
        "BY,BZ,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP" +
        ",CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D2,D3,D4,D5,D6,D7,D8,D9,DA,DB,DC,DD,DE,DF,DG,D" +
        "H,DI,DJ,DK,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DV,DW,DX,DY,DZ,E0,E1,E2,E3,E4,E5,E6,E7," +
        "E8,E9,EA,EB,EC,ED,EE,EF,EG,EH,EI,EJ,EK,EL,EM,EN,EO,EP,EQ,ER,ES,ET,EU,EV,EW,EX,EY" +
        ",EZ,F0,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ,FK,FL,FM,FN,FO,F" +
        "P,FQ,FR,FS,FT,FU,FV,FW,FX,FY,FZ,G0,G1,G2,G3,G4,G5,G6,G7,G8,G9,GA,GB,GC,GD,GE,GF," +
        "GG,GH,GI,GJ,GK,GL,GM,GN,GO,GP,GQ,GR,GS,GT,GU,GV,GW,GX,GY,GZ,H0,H1,H2,H3,H4,H5,H6" +
        ",H7,H8,H9,HA,HB,HC,HD,HE,HF,HG,HH,HI,HJ,HK,HL,HM,HN,HO,HP,HQ,HR,HS,HT,HU,HV,HW,H" +
        "X,HY,HZ,I1,I2,I3,I4,I5,I6,I7,I8,IA,IB,IC,ID,IE,IF,IG,IH,II,IJ,IK,IM,IN,IO,IP,IQ," +
        "IR,IS,IT,IU,IV,IW,IX,IY,IZ,J1,J2,J3,J4,J5,J6,J7,J8,J9,JA,JB,JC,JD,JE,JF,JH,JI,JJ" +
        ",JK,JL,JM,JN,JO,JP,JQ,JR,JS,JT,JU,JV,JW,JX,JY,K0,K1,K2,K3,K4,K5,K6,K7,K8,K9,KA,K" +
        "B,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS,KT,KU,KV,KW,KX,KY,KZ,L1,L2," +
        "L3,L4,L5,L6,L7,LA,LB,LC,LD,LE,LF,LG,LH,LI,LJ,LK,LL,LM,LO,LP,LR,LS,LT,LU,LV,LW,M1" +
        ",M2,MA,MB,MC,MD,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,N" +
        "A,NB,NC,ND,NE,NF,NG,NH,NI,NJ,NK,NL,NN,NP,NR,NU,OL,OO,OP,OR,OT,OV,P1,P2,P3,P4,P5," +
        "P6,P9,PA,PB,PC,PD,PE,PF,PG,PH,PI,PK,PM,PO,PP,PR,PS,PT,PV,PW,PY,PZ,Q1,Q2,Q3,Q4,Q5" +
        ",Q6,Q7,Q8,Q9,QA,QB,QC,QD,QE,QF,QG,QH,QI,QJ,QK,QL,QM,QN,QO,QP,QQ,QR,QS,QT,QU,R1,R" +
        "2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS," +
        "RT,RU,RV,RW,RX,RY,RZ,S1,S2,S3,S5,SA,SB,SC,SD,SE,SF,SG,SH,SL,SM,SN,SO,SP,SQ,SR,ST" +
        ",SU,SV,SW,SX,SY,SZ,T1,T2,T3,T4,T5,T6,TA,TB,TC,TD,TE,TF,TM,TP,TR,TV,U1,U2,U3,U4,U" +
        "5,U6,U7,U8,U9,UA,UB,UC,UD,UE,UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,UR,US,UT,UU,UV," +
        "UW,UX,UY,UZ,V1,V2,V3,V4,V5,V6,V7,VA,VB,VC,VD,VE,VF,VG,VH,VI,VJ,VK,VL,VM,VN,VO,VT" +
        ",VU,W1,W2,W3,W4,W5,W6,W7,W8,W9,WA,WB,WC,WD,WE,WF,WG,WH,WI,WK,WL,WM,WN,WO,WP,WR,W" +
        "S,WT,WU,WV,WW,WX,WY,WZ,XA,XB,XC,XD,XE,XF,XG,XH,XI,XJ,XK,XL,XM,XN,XO,XP,XQ,XR,XS," +
        "XT,XU,XV,XW,XX,XY,XZ,YA,YB,YC,YD,YE,YF,YG,YH,YJ,ZA,ZB,ZC,ZD,ZE,ZF,ZG,ZH,ZI,ZK,ZL" +
        ",ZM,ZN,ZO,ZP,ZQ,ZR,ZS,ZT,ZU,ZW,ZY,ZZ,")]
    public class X12_ID_1321
    {
    }
    
    /// <summary>
    /// Certification Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,A,B,C,D,E,I,R,S,")]
    public class X12_ID_1322
    {
    }
    
    /// <summary>
    /// Routing Sequence Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,D,H,I,JD,JO,M,O,R,S,V,X,Z,")]
    public class X12_ID_133
    {
    }
    
    /// <summary>
    /// Measurement Method or Device
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BM,BO,DM,FT,MA,MM,OM,PT,TM,VA,VB,VC,")]
    public class X12_ID_1373
    {
    }
    
    /// <summary>
    /// Proposal Data Detail Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,")]
    public class X12_ID_1401
    {
    }
    
    /// <summary>
    /// Shipment Method of Payment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",11,BP,CA,CC,CD,CF,DE,DF,FO,HP,MX,NC,NR,PA,PB,PC,PD,PE,PL,PO,PP,PS,PU,RC,RF,RS,TP" +
        ",WC,")]
    public class X12_ID_146
    {
    }
    
    /// <summary>
    /// Special Handling Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",045,15,170,25,35,45,510,520,550,555,565,570,585,665,670,675,761,A1M,A3M,A5M,AAS," +
        "AB,ADL,AFN,AGG,AGS,AIB,AK,ALP,ALT,AMM,ANC,APD,APL,ARC,ARG,ARR,ART,ASY,AT,AUX,AV," +
        "AW,BA,BCP,BKA,BL,BLK,BLS,BN,BNS,BOX,BU2,BU4,BUA,BW,CA2,CA4,CAR,CC,CCB,CCH,CCS,CD" +
        ",CDD,CE,CF,CFC,CFL,CGC,CGR,CGT,CH,CHN,CI,CIP,CIS,CLN,CLS,CM,CMD,CNL,CNS,CO,CON,C" +
        "OR,COU,COV,CPC,CPM,CR,CRL,CSD,CSP,CTL,CTM,CTR,CUF,CW,CX,CY,DA,DBL,DBP,DCS,DDN,DD" +
        "P,DDS,DDZ,DE,DEL,DEP,DET,DEZ,DFD,DFM,DFS,DIS,DLP,DLR,DM,DN,DNC,DNF,DNT,DOC,DOV,D" +
        "PB,DPD,DPE,DPL,DPT,DPU,DR,DRO,DRU,DS,DSK,DSM,DSR,DSV,DT,DTB,DTP,DTV,DU,DV,DW,DWP" +
        ",EAX,ECR,ECS,ED,EDD,EDO,EE,EED,EL,ELS,EMR,EMT,END,EP,ER,ERS,ERT,EV,EW,EX,EXC,EXD" +
        ",EXL,EXO,EXP,EXQ,EXT,EXU,EXZ,EZE,FA,FAK,FAS,FB,FC,FCS,FD,FFC,FFS,FG,FL,FLS,FP,FP" +
        "T,FR,FRZ,FS,FST,FTR,GI,GMS,GOC,GSP,GSS,HAL,HAN,HBR,HDH,HDW,HE,HEA,HES,HET,HH,HM," +
        "HMA,HMI,HO,HOL,HOR,HOS,HOX,HP,HQT,HR,HRS,HT,HTI,HV,HW,HZC,HZD,IB,IC,ID,IDC,IDL,I" +
        "IH,IM,IMP,IMS,INT,IP,IPU,IR,IS,ITS,JIT,JLX,JS,KEG,KMD,LAB,LAY,LB,LBL,LBR,LBT,LC," +
        "LC2,LC4,LCL,LD,LEC,LF,LFD,LHS,LIE,LMD,LME,LN,LP,LPD,LR,LS,LT,LTE,LTT,LYC,MAT,MC," +
        "MEN,MES,MET,MF,MIN,MNS,MOT,MP,MR,MRF,MSS,MTE,MVS,NC,ND,NE,NH,NHC,NHL,NI,NP,NPR,N" +
        "S,NSV,NT,NW,NX,OAH,OBL,OCA,OCL,OCN,OCS,OCV,ODI,OEH,OFH,OFU,OHC,OIL,ONC,ONS,OOB,O" +
        "OD,OOL,OPR,OPT,OS,OSB,OST,OTC,OTD,OTH,OTO,OTS,OUC,OUW,OV,OVR,OWC,OWR,PAJ,PAV,PB," +
        "PD,PDS,PDY,PER,PFH,PG,PHR,PI,PIR,PMM,PMR,PMS,PMT,POC,PPD,PRL,PRT,PS,PSG,PSS,PTS," +
        "PUC,PUD,PUK,PUP,PVB,PVD,PVI,PVL,PVP,PVS,PVT,PW,PYS,RA,RB,RC,RCC,RCL,RDH,RDR,REP," +
        "RES,RFM,RIE,RLS,RM,RMC,RMP,RMS,RO,RPD,RR,RRR,RS,RSP,RSS,RSV,RT,RWR,SAS,SAT,SB,SC" +
        ",SCC,SCL,SD,SDL,SDS,SE,SEC,SED,SEE,SER,SEV,SFB,SFD,SFE,SFT,SGL,SH,SHH,SHL,SHW,SI" +
        ",SK,SKT,SLC,SM,SMP,SMS,SNM,SNS,SNT,SOC,SOL,SP,SPC,SPR,SPT,SPU,SR,SRG,SRS,SSC,SSN" +
        ",SSU,ST,STA,STD,STO,STP,STR,SUA,SUB,SUP,SVS,SW,TA,TC,TDC,TDP,TER,TF,TLS,TMS,TMV," +
        "TN,TOF,TPS,TRA,TRK,TRL,TRM,TRN,TRP,TRS,TRT,TS,TSC,TSP,TSS,TT,TV,UB,UFC,UI,UL,UN," +
        "UP,UPK,UR,URC,US,UTL,VAC,VAN,VCL,VFN,VIS,VN,VSO,VT,VTS,WB,WBB,WCT,WD,WDS,WE,WFG," +
        "WH,WI,WM,WO,WRB,WRI,WTV,WW,XP,XT,ZZZ,")]
    public class X12_ID_152
    {
    }
    
    /// <summary>
    /// Request Category Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AR,BA,HS,IN,PR,RE,SC,")]
    public class X12_ID_1525
    {
    }
    
    /// <summary>
    /// Weight Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,A1,A2,A3,A4,B,C,CD,CE,D,DR,E,F,FR,G,H,I,J,K,L,LC,M,N,ND,NI,NR,NT,O,P,PA,Q,R,RG" +
        ",RN,RT,S,SF,SI,SK,SO,T,U,V,W,WA,WB,WG,WJ,X,Y,Z,")]
    public class X12_ID_187
    {
    }
    
    /// <summary>
    /// Hazardous Material Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",4,6,9,A,C,D,E,F,I,R,T,U,X,")]
    public class X12_ID_208
    {
    }
    
    /// <summary>
    /// Commodity Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",2,3,A,B,C,D,E,F,G,H,I,J,K,L,M,N,P,Q,S,T,U,V,Z,")]
    public class X12_ID_23
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D2,D3,D4,D5,DD,DE,DF,DG,DI,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DV,DW,DX,DY,DZ,E1,E2,E3,E4,E5,E6,EA,EB,EC,ED,EE,EF,EG,EH,EI,EJ,EK,EL,EM,EN,EP,EQ,ER,ES,EU,EX,EZ,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA,FB,FC,FD,FE,FF,FG,FI,FL,FM,FN,FP,FS,FT,FW,GA,GC,GD,GE,GI,GK,GN,GQ,GR,GS,GU,HC,HD,HI,HN,IA,IB,IC,ID,IE,IF,IG,IM,IN,IP,IQ,IR,IS,IT,IV,IW,IZ,JA,JB,JC,JD,JN,JP,JS,KA,KB,KD,KE,KF,KG,KI,KJ,KK,KL,KM,KN,KP,L1,L2,L3,L4,L5,LA,LB,LC,LD,LG,LP,LR,LS,LT,LU,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,N1,N2,N3,N4,N5,N6,NC,ND,NE,NH,NM,NR,NU,NW,NZ,OA,OB,OC,OD,OE,OF,OG,OH,OI,OL,ON,OO,OP,OR,OT,P1,P2,P3,P4,P5,P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,R1,R2,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RR,RS,RT,RU,RV,RW,RY,RZ,S2,S3,S4,S5,S6,S7,S8,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SX,SY,SZ,T2,T3,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TM,TN,TP,TR,TS,TT,TU,TV,TW,TX,TY,TZ,U2,U3,U5,U6,UA,UB,UC,UD,UE,UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,UR,US,UT,UV,UX,VA,VB,VC,VE,VI,VM,VN,VO,VP,VS,VT,VU,VV,VX,W1,W2,W5,W6,W7,WA,WC,WL,WR,WS,XA,XC,XP,XQ,XZ,YP,ZB,ZR,ZZ,")]
    public class X12_ID_235
    {
    }
    
    /// <summary>
    /// Price Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",ACT,AGC,ALT,AWP,BBP,BCH,C01,C02,C03,C04,C05,C06,C07,C08,C09,C10,C11,C12,C13,C14,C15,C16,C17,C18,C19,C20,C21,C22,C23,C24,C25,C26,C27,C28,C29,C30,CAN,CAT,CDF,CDV,CHG,CON,CUP,CUS,D01,D02,D03,DAP,DIS,DPR,DSC,DSD,DSP,EDM,EDP,EDS,EDW,ELC,EST,EUP,FCH,FCP,FDS,FET,FGP,FSP,FUL,FUP,GAP,GDP,GOV,GSP,GTP,ICL,IND,INS,INV,LAR,LPP,LPR,MAP,MAS,MAX,MIN,MNC,MNR,MOD,MPR,MSR,MXR,N01,N02,N03,N04,N05,N06,N07,N08,N09,N10,N11,N12,N13,N14,N15,N16,N17,N18,N19,N20,N21,N22,N23,N24,N25,N26,N27,N28,N29,N30,N31,NET,OAP,OPP,PAP,PAQ,PBQ,PBR,PHS,PIE,PLT,PPA,PPD,PRF,PRO,PRP,PUR,QTE,REG,RES,RPA,RPM,RPP,RSH,RTL,SAC,SDP,SFP,SHD,SLP,SPC,SPE,STA,SUM,SWP,THP,TOT,TRF,UCP,ULC,WAR,WHL,WSP,ZNP,")]
    public class X12_ID_236
    {
    }
    
    /// <summary>
    /// Allowance or Charge Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,N,P,Q,R,S,")]
    public class X12_ID_248
    {
    }
    
    /// <summary>
    /// Vessel Requirement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,M,O,R,S,")]
    public class X12_ID_249
    {
    }
    
    /// <summary>
    /// Service Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,09,3D,9A,AC,AE,AM,BC,CB,CE,CG,CX,D1,D2,D3,DC,DF,DR,DS,DT,ES,ET,FC,G2,GP,GT,IA" +
        ",IE,IX,ME,MW,ND,NF,NH,NM,NS,ON,PA,PB,PC,PI,PM,PN,PO,PR,PS,R1,R2,R3,R4,R5,R6,R7,R" +
        "8,RS,SA,SC,SD,SE,SG,SH,SI,SM,SP,ST,ZZ,")]
    public class X12_ID_284
    {
    }
    
    /// <summary>
    /// Distance Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,D,F,K,L,M,T,X,")]
    public class X12_ID_295
    {
    }
    
    /// <summary>
    /// Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,A,A1,A2,A3,A4,A5,A6,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AL,AP,AQ,AR,AS,AT,AV,AW,AX,B,BD,BI,BO,C,C1,C2,CA,CB,CC,CD,CE,CF,CG,CL,CM,CN,CO,CP,CS,CT,CU,CV,CX,D,D1,D2,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DP,DR,DS,DT,DX,E,EA,EB,EC,ED,EE,EN,EP,ER,EV,EX,F,F1,FA,FC,FI,FO,FR,G,GR,H,HR,I,I1,IA,IM,IN,IS,IT,J,JA,JO,JU,K,KA,L,LC,LQ,M,ME,MO,N,NA,ND,NP,NS,O,OD,OP,OR,OT,P,P1,PA,PB,PC,PD,PF,PI,PJ,PO,PP,PR,PS,PT,PU,PV,Q,R,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,S,S1,S2,SA,SB,SC,SD,SE,SL,SR,SS,SU,SV,SZ,T,TD,TE,TG,TN,TP,TR,TS,TU,U,V,VA,W,W1,WD,WI,WQ,WV,X,Y,Z,")]
    public class X12_ID_306
    {
    }
    
    /// <summary>
    /// Location Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",10,11,12,13,14,18,19,20,21,22,27,28,29,30,31,32,33,34,35,36,38,39,40,41,42,43,44,45,46,47,48,49,50,52,53,54,55,57,58,59,60,93,94,A,A1,AA,AC,AP,AR,B,B1,BE,BL,BS,C,C2,CA,CB,CC,CD,CE,CI,CL,CO,CR,CS,CY,D,DC,DE,DL,DO,DP,DR,DT,E,EA,EL,F,FA,FE,FF,FI,FR,FS,FT,FV,GL,H,I,IA,IB,IM,IP,IS,IT,K,KE,KL,KP,L,LO,M,MI,MS,MZ,NS,O,OA,OF,OL,OP,OR,OV,P,PA,PB,PC,PD,PE,PF,PG,PH,PL,PO,PP,PQ,PR,PS,PT,PU,RA,RC,RE,RG,RJ,RL,RS,RT,SA,SB,SC,SD,SE,SG,SH,SL,SN,SP,SS,ST,SW,TA,TC,TL,TM,TN,TP,TR,TX,UN,UR,UT,VA,VI,VS,W,WF,WH,WI,ZN,ZZ,")]
    public class X12_ID_309
    {
    }
    
    /// <summary>
    /// Allowance or Charge Method of Handling Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,15,18,20,21,25,CA,CC,PP,ZZ,")]
    public class X12_ID_331
    {
    }
    
    /// <summary>
    /// Terms Basis Date Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",09,1,10,11,12,13,14,15,16,2,3,4,5,6,7,8,ZZ,")]
    public class X12_ID_333
    {
    }
    
    /// <summary>
    /// Transportation Terms Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,ZZ,")]
    public class X12_ID_334
    {
    }
    
    /// <summary>
    /// Transportation Terms Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CAF,CFR,CIF,CIP,CPT,DAF,DDP,DDU,DEQ,DES,DOM,DUP,EXQ,EXS,EXW,FAS,FCA,FCI,FCP,FOB," +
        "FOR,FOT,NPF,PPF,ZZZ,")]
    public class X12_ID_335
    {
    }
    
    /// <summary>
    /// Terms Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,52,54,55,5" +
        "6,57,58,61,63,64,65,CA,CO,NC,PP,ZZ,")]
    public class X12_ID_336
    {
    }
    
    /// <summary>
    /// Unit of Time Period or Interval
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AD,AM,AN,AP,AY,BD,BM,BW,CC,CY,DA,DW,DY,EL,F1,F2,FY,HR,ID,KK,KL,LN,LT,MD,MI,MO" +
        ",MS,MT,NX,PA,PD,PM,PR,Q1,Q2,Q3,Q4,QY,SA,SD,SH,SM,SP,TY,WK,WW,WY,YD,ZZ,")]
    public class X12_ID_344
    {
    }
    
    /// <summary>
    /// Lead Time Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AP,AR,AS,AT,AU,AV,AW,AX,AY,AZ,BA,BB,BC,BD" +
        ",BE,BF,BG,")]
    public class X12_ID_345
    {
    }
    
    /// <summary>
    /// Item Description Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,S,X,")]
    public class X12_ID_349
    {
    }
    
    /// <summary>
    /// Transaction Set Purpose Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,07,08,10,11,12,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28" +
        ",30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,5" +
        "6,5C,77,CN,CO,EX,GR,PR,RH,RV,SU,ZZ,")]
    public class X12_ID_353
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H" +
        ",1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1X,20,21,22,23,24,25,26,27,28,29,2A,2B,2C,2F,2G,2" +
        "H,2I,2J,2K,2L,2M,2N,2P,2Q,2R,2U,2V,2W,2X,2Y,2Z,30,31,32,33,34,35,36,37,38,39,3B," +
        "3C,3E,3F,3G,3H,3I,40,41,43,44,45,46,47,48,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4K,4L,4M" +
        ",4N,4O,4P,4Q,4R,4S,4T,4U,4V,4W,4X,50,51,52,53,54,56,57,58,59,5A,5B,5C,5E,5F,5G,5" +
        "H,5I,5J,5K,5P,5Q,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,76,77,78,79,80,81," +
        "82,83,84,85,86,87,89,8C,8D,8P,8R,8S,8U,90,91,92,93,94,95,96,97,98,99,A8,AA,AB,AC" +
        ",AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B0,B1,B2,B" +
        "3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT," +
        "BU,BV,BW,BX,BY,BZ,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK" +
        ",CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D2,D3,D5,D8,D9,DA,DB,DC,DD,DE,DF,D" +
        "G,DH,DI,DJ,DK,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DW,DX,DY,DZ,E1,E3,E4,E5,E7,E8,E9,EA," +
        "EB,EC,ED,EE,EF,EG,EH,EJ,EM,EP,EQ,EV,EX,EY,EZ,F1,F2,F3,F4,F5,F6,F9,FA,FB,FC,FD,FE" +
        ",FF,FG,FH,FJ,FK,FL,FM,FO,FP,FR,FS,FT,FZ,G2,G3,G4,G5,G7,GA,GB,GC,GD,GE,GF,GG,GH,G" +
        "I,GJ,GK,GL,GM,GN,GO,GP,GQ,GR,GS,GT,GU,GV,GW,GX,GY,GZ,H1,H2,H4,HA,HB,HC,HD,HE,HF," +
        "HG,HH,HI,HJ,HK,HL,HM,HN,HO,HP,HQ,HR,HS,HT,HU,HV,HW,HY,HZ,IA,IB,IC,IE,IF,IH,II,IK" +
        ",IL,IM,IN,IP,IT,IU,IV,IW,J2,JA,JB,JE,JG,JK,JM,JO,JR,JU,K1,K2,K3,K4,K5,K6,K7,K9,K" +
        "A,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KO,KP,KQ,KR,KS,KT,KU,KV,KW,KX,L2,LA,LB,LC," +
        "LE,LF,LG,LH,LI,LJ,LK,LL,LM,LN,LO,LP,LQ,LR,LS,LT,LX,LY,M0,M1,M2,M3,M4,M5,M6,M7,M8" +
        ",M9,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,M" +
        "Z,N1,N2,N3,N4,N6,N7,N9,NA,NB,NC,ND,NE,NF,NG,NH,NI,NJ,NL,NM,NN,NQ,NR,NS,NT,NU,NV," +
        "NW,NX,NY,OA,OC,ON,OP,OT,OZ,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,PH" +
        ",PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,Q1,Q2,Q3,Q4,Q5,Q6,Q7,QA,Q" +
        "B,QC,QD,QE,QH,QK,QR,QS,QT,QU,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RG,RH,RK," +
        "RL,RM,RN,RO,RP,RS,RT,RU,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ" +
        ",SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SV,SW,SX,SY,SZ,T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,TA,T" +
        "B,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TS,TT,TU,TV,TW,TX,TY,TZ,U1,U2," +
        "U3,U5,UA,UB,UC,UD,UE,UF,UH,UL,UM,UN,UP,UQ,UR,US,UT,UU,UV,UW,UX,UY,UZ,V1,V2,VA,VC" +
        ",VI,VP,VR,VS,W2,WA,WB,WD,WE,WG,WH,WI,WK,WM,WP,WR,WW,X1,X2,X3,X4,X5,X6,X7,X8,X9,X" +
        "P,Y1,Y2,Y3,Y4,YD,YL,YR,YT,Z1,Z2,Z3,Z4,Z5,Z6,Z8,ZA,ZB,ZC,ZP,ZZ,")]
    public class X12_ID_355
    {
    }
    
    /// <summary>
    /// Note Reference Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AAA,AAB,AAC,AAD,AAE,AAF,ABN,ACC,ACI,ACN,ACS,ACT,ADD,AES,AET,ALG,ALL,ALT,AMN,AOO,APN,APS,BBD,BBF,BBH,BBN,BBO,BBT,BFD,BOL,BUR,CAA,CAB,CAC,CAD,CAE,CAF,CAG,CAH,CAI,CAJ,CAK,CAL,CAM,CAN,CAO,CAP,CAQ,CAR,CAS,CAT,CAU,CAV,CAW,CAX,CAZ,CBA,CBB,CBC,CBH,CBI,CCA,CCB,CCC,CCD,CCE,CCF,CCG,CCN,CDD,CER,CHG,CIG,CLN,CLR,CMP,CMT,COD,COM,CON,CRA,CRK,CRN,CUS,DCP,DEE,DEL,DEP,DFR,DFS,DGN,DME,DOD,DOI,ECD,ECM,ECN,ECT,EED,EFD,ELE,EMC,EMD,ENR,ERN,EVL,EXE,EXR,EXT,FEE,FUT,GEN,GPI,GSI,HHI,ICN,IDT,IID,IIE,IIR,IMP,INS,INT,INV,IVC,JVD,LAB,LBD,LBS,LEN,LIN,LIQ,LLA,LLB,LLC,LOC,LOI,LSD,MCD,MDO,MED,MFG,MKN,MMD,MSD,NCD,NPD,NTR,OBI,OBL,OCA,OCC,OCL,OCP,OCR,ODT,OLS,OPO,ORA,ORE,ORI,OTH,OTN,OTS,PAY,PCS,PDS,PED,PEN,PES,PID,PKG,PMT,POB,POC,POL,PPC,PRI,PRN,PRO,PRR,PSY,PUR,QUL,QUT,RDI,REC,REG,REP,REV,RFL,RHB,RLA,RLH,RNH,RNI,ROU,RPT,RST,RVC,SAN,SCN,SDD,SET,SFM,SMD,SOB,SOW,SPH,SPT,SPV,SSA,SSC,SSD,SSE,SSG,SSH,SSI,SSS,SST,TAF,TCF,TDA,TES,TIL,TLF,TLR,TPO,TRA,TRE,TRF,TRS,TSD,TSF,TST,UPI,VEC,VNN,WHI,WRP,ZZZ,")]
    public class X12_ID_363
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AP,AS,AU,BN,BT,CA,CP,DN,ED,EM,EX,FT,FU,FX,HF,HP,IT,MN,NP,OF,OT,PA,PC" +
        ",PP,PS,SP,TE,TL,TM,TN,TX,UR,VM,WC,WF,WP,")]
    public class X12_ID_365
    {
    }
    
    /// <summary>
    /// Contact Function Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1A,1B,1C,1D,1E,1F,1G,1H,3A,A1,A2,A3,A4,A5,AA,AB,AC,AD,AE,AF,AG,AH,AI,AL,AM,AN,AP,AR,AS,AT,AU,AV,BA,BB,BC,BD,BI,BJ,BK,BL,BM,BP,BS,BU,C2,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CR,CS,CT,CU,CV,CW,CX,CY,CZ,DA,DC,DD,DE,DF,DI,DM,DN,DV,E1,E2,EA,EB,EC,ED,EF,EG,EM,EN,EO,EP,ES,EV,EX,FA,FB,FC,FD,FF,FL,FM,FN,FO,FP,FQ,FR,GA,GB,GC,GE,GR,HM,HR,IC,IO,IP,IS,KA,KB,KC,KP,KT,LD,MA,MB,MC,MD,ME,MG,MK,ML,MM,NA,NC,NP,NT,OA,OC,OD,OS,OW,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,QA,QC,QI,QM,QP,QR,QY,RA,RB,RC,RD,RE,RF,RG,RP,RQ,RS,RZ,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SY,TA,TB,TC,TD,TE,TH,TM,TN,TP,TR,TY,UG,UP,UQ,UR,VM,VP,WH,WI,WR,ZZ,")]
    public class X12_ID_366
    {
    }
    
    /// <summary>
    /// Shipment/Order Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AA,AB,AN,AP,AS,AU,AV,BK,BM,BO,BP,BT,BW,CA,CB,CC,CD,CE,CF,CI,CK,CL,CM,CN,CO,CP,CS,CT,CU,DA,DD,DE,DI,DO,DP,DR,DS,EC,ED,EW,EX,FS,HQ,IC,ID,IN,IP,IS,LM,LS,LW,MC,NF,NN,NS,NY,OB,OF,OP,OR,PA,PC,PD,PH,PI,PK,PL,PN,PO,PP,PR,PS,PT,QN,QP,RC,RD,RI,RT,RW,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SP,SQ,SS,ST,SU,UB,UN,UR,WS,ZZ,")]
    public class X12_ID_368
    {
    }
    
    /// <summary>
    /// Change Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AQ,BB,BD,C1,C2,C3,C4,C5,C6,DC,EV,FE,GU,GW,LD,MC,MP,PC,PQ,PS,QH,QO,QP,QT,SC,UM,UP" +
        ",WD,WO,ZZ,")]
    public class X12_ID_371
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,016,017,018,019,020," +
        "021,022,023,024,025,026,027,028,029,030,031,032,033,034,035,036,037,038,039,040," +
        "041,042,043,044,045,046,047,048,049,050,051,052,053,054,055,056,057,058,059,060," +
        "061,062,063,064,065,066,067,068,069,070,071,072,073,074,075,076,077,078,079,080," +
        "081,082,083,084,085,086,087,088,089,090,091,092,093,094,095,096,097,098,099,100," +
        "101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,118,119,120,121," +
        "122,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142," +
        "143,144,145,146,147,148,149,150,151,152,153,154,155,156,157,158,159,160,161,162," +
        "163,164,165,166,167,168,169,170,171,172,173,174,175,176,177,178,179,180,181,182," +
        "183,184,185,186,187,188,189,190,191,192,193,194,195,196,197,198,199,200,201,202," +
        "203,204,205,206,207,208,209,210,211,212,213,214,215,216,217,218,219,220,221,222," +
        "223,224,225,226,227,228,229,230,231,232,233,234,235,236,237,238,239,240,241,242," +
        "243,244,245,246,247,248,249,250,251,252,253,254,255,256,257,258,259,260,261,262," +
        "263,264,265,266,267,268,269,270,271,272,273,274,275,276,277,278,279,280,281,282," +
        "283,284,285,286,287,288,289,290,291,292,293,294,295,296,297,298,299,300,301,302," +
        "303,304,305,306,307,308,309,310,311,312,313,314,315,316,317,318,319,320,321,322," +
        "323,324,325,326,327,328,329,330,331,332,333,334,335,336,337,338,339,340,341,342," +
        "343,344,345,346,347,348,349,350,351,352,353,354,355,356,357,358,359,360,361,362," +
        "363,364,365,366,367,368,369,370,371,372,373,374,375,376,377,378,379,380,381,382," +
        "383,384,385,386,387,388,389,390,391,392,393,394,395,396,397,398,399,400,401,402," +
        "403,404,405,406,408,409,410,411,412,413,414,415,416,417,418,419,420,421,422,423," +
        "424,425,426,427,428,429,430,431,432,433,434,435,436,437,438,439,440,441,442,443," +
        "444,445,446,447,448,449,450,451,452,453,454,455,456,457,458,459,460,461,462,463," +
        "464,465,466,467,468,469,470,471,472,473,474,475,476,477,478,479,480,481,482,483," +
        "484,485,486,487,488,489,490,491,492,493,494,495,496,497,498,499,500,501,502,503," +
        "504,505,506,507,508,509,510,511,512,513,514,515,516,517,518,519,520,521,522,523," +
        "524,525,526,527,528,529,530,531,532,533,534,535,536,537,538,539,540,541,542,543," +
        "544,545,546,547,548,549,550,551,552,553,554,555,556,557,558,559,560,561,562,563," +
        "564,565,566,567,568,569,570,571,572,573,574,575,576,577,578,579,580,581,582,583," +
        "584,585,586,587,589,590,591,592,593,594,595,596,597,598,599,600,601,602,603,604," +
        "606,607,608,609,610,611,612,613,614,615,616,617,618,619,620,621,622,623,624,625," +
        "626,627,629,630,631,632,633,634,635,636,637,638,640,641,642,643,644,646,647,648," +
        "649,650,651,652,653,655,656,657,658,659,660,661,662,663,664,665,666,667,668,669," +
        "670,671,672,673,674,675,681,682,683,684,685,686,687,688,689,690,691,692,693,694," +
        "695,696,697,699,700,701,702,703,704,705,706,707,708,709,710,711,712,713,714,715," +
        "716,717,718,719,720,721,722,723,724,725,726,727,728,729,730,731,732,733,734,736," +
        "737,738,739,740,741,742,743,744,745,746,750,751,752,753,754,755,756,757,758,760," +
        "770,771,773,774,776,778,779,780,781,782,783,784,785,786,789,800,801,802,803,804," +
        "805,806,807,808,809,810,811,812,813,814,815,816,817,818,820,821,822,823,824,825," +
        "826,827,828,830,831,832,840,841,842,843,844,845,846,847,848,849,850,851,853,854," +
        "855,856,857,858,859,860,861,862,863,864,865,866,867,868,869,870,871,872,873,874," +
        "875,876,877,878,879,880,881,882,883,884,885,900,901,903,904,905,906,907,908,909," +
        "910,911,912,913,914,915,916,917,918,919,920,921,922,923,924,925,926,927,928,929," +
        "930,931,932,933,934,935,936,937,938,939,940,941,942,943,944,945,946,947,948,949," +
        "950,951,952,953,954,955,956,957,960,961,962,963,964,965,966,967,968,969,970,971," +
        "972,973,974,975,976,977,978,979,980,981,982,983,984,985,986,987,988,989,992,993," +
        "994,995,996,997,998,999,AA1,AA2,AA3,AA4,AA5,AA6,AA7,AA8,AA9,AAA,AAB,AAD,AAE,AAF," +
        "AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AAZ," +
        "AB1,AB2,AB3,AB4,AB5,AB6,AB7,AB8,AB9,ABA,ABB,ABC,ABD,ABE,ABG,ABH,ABI,ABK,ABL,ABM," +
        "ABN,ABO,ABP,ABQ,ABR,ABS,ABT,ABU,ABV,ABW,ABX,ABY,ACA,ACB,ACK,ADB,ADC,ADD,ADL,ADM," +
        "ADR,ARD,CAD,CCR,CDT,CEA,CEB,CEC,CED,CEE,CEF,CEH,CEJ,CEK,CEL,CEM,CEN,CEO,CLO,CLU," +
        "COM,CON,CUR,DDO,DEE,DET,DFF,DFS,DIS,DOI,DSP,ECD,ECF,ECS,ECT,EPP,ESC,ESF,ESS,EST," +
        "ETP,EXO,EXP,FFI,GRD,ICF,IDG,III,IMP,INC,INT,KEV,KEW,LAS,LCC,LEA,LEL,LIQ,LLP,LOG," +
        "LPC,LSC,LTP,MRR,MSD,NAM,NFD,NRG,NSD,ORG,PBC,PDV,PLS,PPP,PRD,PRR,PTD,RAP,RES,RFD," +
        "RFF,RFO,RNT,RRM,RRT,RSD,RSS,RTO,SCV,SDD,STN,TSR,TSS,TST,VAT,VLU,W01,W02,W03,W05," +
        "W06,W07,W08,W09,W10,W11,W12,W13,WAY,YXX,YXY,ZZZ,")]
    public class X12_ID_374
    {
    }
    
    /// <summary>
    /// Allowance/Charge Percent Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,Z,")]
    public class X12_ID_378
    {
    }
    
    /// <summary>
    /// Equipment Description Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",20,2B,2D,2E,2F,2G,40,4B,AC,AF,AL,AP,AT,BC,BE,BF,BG,BH,BJ,BK,BO,BR,BX,CA,CB,CC,CD,CG,CH,CI,CJ,CK,CL,CM,CN,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CZ,DD,DF,DT,DX,ET,FF,FH,FN,FP,FR,FS,FT,FX,GS,HB,HC,HO,HP,HT,HV,HY,ID,IX,LO,LS,LU,NX,OB,OT,OV,PL,PP,PT,PU,RA,RC,RD,RE,RF,RG,RI,RO,RR,RS,RT,SA,SC,SD,SK,SL,SR,SS,ST,SV,TA,TB,TC,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TT,TU,TV,TW,UA,UB,UC,UD,UE,UL,UP,VA,VE,VL,VR,VS,VT,WR,WY,")]
    public class X12_ID_40
    {
    }
    
    /// <summary>
    /// Unit Load Option Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,ZZ,")]
    public class X12_ID_400
    {
    }
    
    /// <summary>
    /// Seal Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,")]
    public class X12_ID_407
    {
    }
    
    /// <summary>
    /// Tax Exempt Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,")]
    public class X12_ID_441
    {
    }
    
    /// <summary>
    /// Credit/Debit Flag Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,")]
    public class X12_ID_478
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,0A,0B,0C,0D,0E,0F,0G,0H,0I,0J,0K,0L,0M,0N,0P,0Q,0R,0S" +
        ",0T,0U,1,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H,1J,1K,1L,1M,1N,1P" +
        ",1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,2,20,21,22,23,24,25,26,27,28,29,2A,2B,2C,2D,2E,2F" +
        ",2G,2H,2I,2J,2K,2L,2M,2N,2P,2Q,2R,2S,2T,2U,2V,2W,2X,2Y,2Z,3,30,31,32,33,34,35,36" +
        ",37,38,39,3A,3B,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R,3S,3T,3U,3V,3W,3" +
        "X,3Y,3Z,4,40,41,42,43,44,45,46,47,48,49,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4K,4L,4M,4" +
        "N,4O,4P,4Q,4R,4S,4T,4U,4V,4W,4X,4Y,4Z,5,50,51,52,53,54,55,56,57,58,59,5A,5B,5C,5" +
        "D,5E,5F,5G,5H,5I,5J,5K,5L,5M,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z,6,60,61,62,6" +
        "3,64,65,66,67,68,69,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R,6S,6T," +
        "6U,6V,6W,6X,6Y,6Z,7,70,71,72,73,74,75,76,77,78,79,7A,7B,7C,7D,7E,7F,7G,7H,7I,7J," +
        "7K,7L,7M,7N,7O,7P,7Q,7R,7S,7T,7U,7V,7W,7X,7Y,7Z,8,80,81,82,83,84,85,86,87,88,89," +
        "8A,8B,8C,8D,8E,8F,8G,8H,8I,8J,8K,8L,8M,8N,8O,8P,8Q,8R,8S,8T,8U,8V,8W,8X,8Y,8Z,9," +
        "90,91,92,93,94,95,96,97,98,99,9A,9B,9C,9D,9E,9F,9G,9H,9I,9J,9K,9L,9M,9N,9O,9P,9Q" +
        ",9R,9S,9T,9U,9V,9W,9X,9Y,9Z,A,A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AAA,AAB,AAC,AAD,A" +
        "AE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,A" +
        "AY,AAZ,AB,ABA,ABB,ABC,ABD,ABE,ABF,ABG,ABH,ABI,ABJ,ABK,ABL,ABM,ABN,ABO,ABP,ABQ,AB" +
        "R,ABS,ABT,ABU,ABV,ABW,ABX,ABY,ABZ,AC,ACA,ACB,ACC,ACD,ACE,ACF,ACG,ACH,ACI,ACJ,ACK" +
        ",ACL,ACM,ACN,ACO,ACP,ACQ,ACR,ACS,ACT,ACU,ACV,ACW,ACX,ACY,ACZ,AD,ADA,ADB,ADC,ADD," +
        "ADE,ADF,ADG,ADH,ADI,ADJ,ADK,ADL,ADM,ADN,ADO,ADP,ADQ,ADR,ADS,ADT,ADW,ADX,ADY,ADZ," +
        "AE,AEB,AEC,AED,AEE,AEF,AEG,AEH,AEI,AEJ,AEK,AEL,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP," +
        "AQ,AR,AS,AT,AU,AV,AVE,AW,AX,AY,AZ,B,B0,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BAA,BAB,BAC" +
        ",BAD,BAE,BAF,BAG,BAH,BAI,BAJ,BAK,BAL,BAM,BAN,BAO,BAP,BAQ,BAR,BAS,BAT,BAU,BAV,BAW" +
        ",BAX,BAY,BAZ,BB,BBA,BBB,BBC,BBD,BBE,BBF,BBG,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN," +
        "BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD," +
        "CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D,D0,D1,D2,D3," +
        "D4,D5,D6,D7,D8,D9,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU" +
        ",DV,DW,DX,DY,DZ,E,E0,E1,E2,E3,E4,E5,E6,E7,E8,E9,EA,EB,EC,ED,EE,EF,EG,EH,EI,EJ,EK" +
        ",EL,EM,EN,EO,EP,EQ,ER,ES,ET,EU,EV,EW,EX,EY,EZ,F,F0,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA" +
        ",FB,FBA,FC,FD,FE,FF,FG,FH,FI,FJ,FK,FL,FM,FN,FO,FP,FQ,FR,FS,FT,FU,FV,FW,FX,FY,FZ," +
        "G,G0,G1,G2,G3,G4,G5,G6,G7,G8,G9,GA,GB,GC,GD,GE,GF,GG,GH,GI,GJ,GK,GL,GM,GN,GO,GP," +
        "GQ,GR,GS,GT,GU,GV,GW,GX,GY,GZ,H,H0,H1,H2,H3,H4,H5,H6,H7,H8,H9,HA,HB,HC,HD,HE,HF," +
        "HG,HH,HI,HJ,HK,HL,HM,HN,HO,HP,HQ,HR,HS,HT,HU,HV,HW,HX,HY,HZ,I,I0,I1,I2,I3,I4,I5," +
        "I6,I7,I8,I9,IA,IB,IC,ID,IE,IF,IG,IH,II,IJ,IK,IL,IM,IN,IO,IP,IQ,IR,IS,IT,IU,IV,IW" +
        ",IX,IY,IZ,J,J0,J1,J2,J3,J4,J5,J6,J7,J8,J9,JA,JB,JC,JD,JE,JF,JG,JH,JI,JJ,JK,JL,JM" +
        ",JN,JO,JP,JQ,JR,JS,JT,JU,JV,JW,JX,JY,JZ,K,K0,K1,K2,K3,K4,K5,K6,K7,K8,K9,KA,KB,KC" +
        ",KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS,KT,KU,KV,KW,KX,KY,KZ,L,L0,L1,L2" +
        ",L3,L4,L5,L6,L7,L8,L9,LA,LB,LC,LD,LE,LF,LG,LH,LI,LJ,LK,LL,LM,LN,LO,LOW,LP,LQ,LR," +
        "LS,LT,LU,LV,LW,LX,LY,LZ,M,M0,M1,M2,M3,M4,M5,M6,M7,M8,M9,MA,MB,MC,MD,ME,MF,MG,MH," +
        "MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,N,N0,N1,N2,N3,N4,N5,N6,N7," +
        "N8,N9,NA,NB,NC,ND,NE,NF,NG,NH,NI,NJ,NK,NL,NM,NN,NO,NP,NQ,NR,NS,NT,NU,NV,NW,NX,NY" +
        ",NZ,O,O0,O1,O2,O3,O4,O5,O6,O7,O8,O9,OA,OB,OC,OD,OE,OF,OG,OH,OI,OJ,OK,OL,OM,ON,OO" +
        ",OP,OQ,OR,OS,OT,OU,OV,OW,OX,OY,OZ,P,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PCC,P" +
        "CS,PCV,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,Q,Q0" +
        ",Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,QA,QB,QC,QD,QE,QF,QG,QH,QI,QJ,QK,QL,QM,QN,QO,QP,QQ,Q" +
        "R,QS,QT,QU,QV,QW,QX,QY,QZ,R,R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,R" +
        "H,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,S,S0,S1,S2,S3,S4,S5,S6,S" +
        "7,S8,S9,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SOF,SP,SQ,SR,SS,ST,SU,SV,SW" +
        ",SX,SY,SZ,T,T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM" +
        ",TN,TO,TP,TQ,TR,TS,TT,TU,TW,TX,TY,TZ,U,U0,U1,U2,U3,U4,U5,U6,U7,U8,U9,UA,UB,UC,UD" +
        ",UE,UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UPF,UQ,UR,US,UT,UU,UV,UW,UX,UY,UZ,V,V0,V1,V" +
        "2,V3,V4,V5,V6,V7,V8,V9,VA,VB,VC,VD,VE,VES,VF,VG,VH,VI,VJ,VK,VL,VM,VN,VO,VP,VQ,VR" +
        ",VS,VT,VU,VV,VW,VX,VY,VZ,W,W0,W1,W2,W3,W4,W5,W6,W7,W8,W9,WA,WB,WC,WD,WE,WF,WG,WH" +
        ",WI,WJ,WK,WL,WM,WN,WO,WP,WQ,WR,WS,WT,WU,WV,WW,WX,WY,WZ,X,X0,X1,X2,X3,X4,X5,X6,X7" +
        ",X8,X9,XA,XB,XC,XD,XE,XF,XG,XH,XI,XJ,XK,XL,XM,XN,XO,XP,XQ,XR,XS,XT,XU,XV,XW,XX,X" +
        "Y,XZ,Y,Y1,Y2,Y3,Y4,Y5,Y6,Y7,Y8,Y9,YA,YB,YC,YD,YE,YF,YG,YH,YI,YJ,YK,YL,YM,YN,YO,Y" +
        "Q,YR,YS,YT,YU,YV,YW,YX,YY,YZ,Z,Z0,Z1,Z2,Z3,Z4,Z5,Z6,Z7,Z8,Z9,ZA,ZB,ZC,ZD,ZE,ZF,Z" +
        "G,ZH,ZI,ZJ,ZK,ZL,ZM,ZN,ZO,ZP,ZQ,ZR,ZS,ZT,ZU,ZV,ZW,ZX,ZY,ZZ,")]
    public class X12_ID_522
    {
    }
    
    /// <summary>
    /// Risk of Loss Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BY,FE,IM,IR,LR,PP,SE,SR,ZZ,")]
    public class X12_ID_54
    {
    }
    
    /// <summary>
    /// Agency Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,93,94,A1,A2,A3,A4,AA,AB,AC,AD,AE,AG,AH,AI,AJ,AL,AM,AP,AQ,AS,AT,AW,AX,AY,BE,BF,BI,CA,CB,CC,CE,CI,CL,CM,CO,CR,CS,CU,CX,DA,DD,DE,DF,DI,DL,DN,DO,DR,DS,DX,DY,DZ,EI,EP,ES,ET,EU,EX,FA,FC,FD,FG,FH,FI,GC,GS,GU,HC,HI,HS,HU,IA,IB,IC,IM,IN,IS,JA,LA,LB,LI,MA,MB,MC,ME,MI,MP,MS,MV,NA,NB,NC,NE,NF,NG,NI,NR,NS,NT,NU,NW,OI,OP,OS,PA,PC,SA,SE,SL,SP,ST,TA,TB,TC,TD,TI,TM,TP,TR,TX,UC,UN,VI,WH,ZZ,")]
    public class X12_ID_559
    {
    }
    
    /// <summary>
    /// Special Services Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A0010,A0020,A0030,AC,AD,AF,AG,AM,AO,B0020,B0040,BH,BI,BOP,C0012,C0032,C0036,C0038,C1,C2,CA,CC,CD,CH,CI,CM,CN,CO,CS,CT,CU,CY,CZ,D0020,D0024,D0031,D0032,D1,D2,DA,DE,DH,DI,DL,DS,DV,E0030,EG,EM,EN,ER,EU,EX,F1,FG,FS,G0010,G0052,GI,GP,GU,H1,HC,HH,HS,I0012,I0013,I0021,I0022,IC,ID,IG,IK,IL,IM,IN,IO,IP,IQ,IR,IS,IT,KO,L1,LA,LL,LS,M0010,M0042,MI,ML,MNTAN,MNTMN,MNTON,N0020,N0021,N0032,NC,OA,ON,OP,P0012,P0014,P0016,P0018,P0022,PA,PB,PC,PE,PF,PL,PLI,PM,PO,PP,PSF,R0072,R0076,R0077,R0110,RD,RE,RM,RP,S0014,S0016,S0022,S0024,S0050,S0052,S0054,S0056,S0080,S1,S2,S3,SD,SG,SH,SJ,SLP,SPI,SR,SS,ST,SU,SV,SW,T0070,T1,TC,TE,TH,TM,TO,UN,US,V1,V2,W0010,WC,WH,X0010,XP,XX,YY,ZZ,")]
    public class X12_ID_560
    {
    }
    
    /// <summary>
    /// Sales Requirement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",8A,AI,AS,B,BC,BK,C,D,E,EI,F,FT,GS,IP,IS,K,LS,MY,N,NS,O,P,P2,P3,P4,Q,QB,QE,QI,QM," +
        "QP,R,S,SC,SE,SF,SG,SI,SP,SQ,SS,ST,SU,SV,SW,T,UC,UL,UP,W,WY,Y,YI,Z,")]
    public class X12_ID_563
    {
    }
    
    /// <summary>
    /// Product/Service Substitution Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B0,B1,B2,B3,B4,X,Y,ZZ,")]
    public class X12_ID_566
    {
    }
    
    /// <summary>
    /// Acknowledgment Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AC,AD,AE,AH,AK,AP,AT,NA,RD,RF,RJ,RN,RO,RV,ZZ,")]
    public class X12_ID_587
    {
    }
    
    /// <summary>
    /// Time Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,AD,AS,AT" +
        ",CD,CS,CT,ED,ES,ET,GM,HD,HS,HT,LT,MD,MS,MT,ND,NS,NT,PD,PS,PT,TD,TS,TT,UT,")]
    public class X12_ID_623
    {
    }
    
    /// <summary>
    /// Basis of Unit Price Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AA,AB,AP,AW,BD,BR,BW,CA,CP,CR,CT,DI,DP,DR,DS,EC,EH,ES,FB,FO,FX,HF,HP,HT,KA,KP,KR,LC,LD,LE,LM,LR,ME,ML,NC,NE,NQ,NS,NT,PA,PB,PD,PE,PF,PG,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PY,QE,QH,QR,QS,QT,RC,RD,RE,RM,RS,RT,SA,SC,SM,SR,ST,SW,TB,TC,TD,TE,TF,TM,TP,TT,UM,VQ,WC,WD,WE,WH,WI,WM,")]
    public class X12_ID_639
    {
    }
    
    /// <summary>
    /// Transaction Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,33,34,35,36,37,38,39,3M,40,41,60,62,63,64,65,66,67,68,69,6A,6C,6N,6R,6S,70,71,72,73,74,75,76,77,78,79,80,81,82,83,85,87,88,91,94,95,97,98,99,A0,A1,A3,A4,A5,A6,A7,AA,AB,AC,AD,AE,AF,AG,AI,AM,AN,AP,AQ,AR,AS,AT,AV,AW,AZ,BA,BB,BD,BF,BH,BJ,BK,BL,BM,BN,BO,BP,BR,BS,BT,BU,BV,BW,C0,C1,C2,C3,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D4,DA,DB,DC,DD,DE,DF,DG,DH,DI,DK,DL,DN,DO,DP,DQ,DR,DS,DT,DU,EA,EB,EF,EI,EM,EP,ER,EX,FA,FB,FC,FD,FE,FF,FG,FI,FL,FM,FN,FP,FR,FS,FT,GA,GI,GR,HP,I1,IA,IB,IC,ID,IE,IF,II,IM,IN,IO,IR,IU,IW,IX,IZ,JM,JO,JR,JS,JU,JX,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KN,KS,KT,LC,LD,LE,LF,LN,LO,LP,LR,LV,M1,MA,MB,MC,MD,ME,MF,MI,ML,MM,MP,MR,MS,MU,N1,N2,N3,N4,N5,N6,N7,N8,NA,NB,NC,ND,NE,NF,NG,NH,NI,NJ,NK,NL,NM,NO,NP,NQ,NR,NT,NU,OC,OF,OP,OR,P1,PA,PB,PC,PD,PE,PF,PG,PI,PL,PM,PO,PP,PR,PS,PT,PU,PV,PW,PX,PZ,QA,QB,QC,QD,QE,QF,QG,QH,QJ,QK,QL,QP,QR,R1,R2,R3,R4,R5,R6,R7,R8,RA,RB,RC,RD,RE,RF,RG,RH,RK,RM,RP,RQ,RS,RT,RU,RZ,S1,S2,S3,S4,SA,SB,SC,SD,SE,SF,SG,SH,SL,SM,SO,SP,SQ,SR,SS,ST,SU,SV,TD,TG,TH,TI,TJ,TK,TP,TR,TS,TT,TX,U1,U2,U4,U5,U9,UA,UC,UD,UF,UI,UM,UO,UP,UR,UT,V1,VH,VJ,VL,VM,VN,VO,VP,VQ,VR,W1,W4,W5,WA,WC,WD,WH,WO,WS,WT,X1,XA,XB,XC,XD,XX,XY,XZ,YI,YR,ZA,ZB,ZC,ZD,ZE,ZF,ZG,ZH,ZI,ZJ,ZK,ZL,ZM,ZN,ZO,ZP,ZQ,ZR,ZS,ZT,ZU,ZW,ZZ,")]
    public class X12_ID_640
    {
    }
    
    /// <summary>
    /// Price Multiplier Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CSD,CSR,DIS,ILP,PSP,SEL,")]
    public class X12_ID_648
    {
    }
    
    /// <summary>
    /// Discount Terms Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AMT,CSH,DOR,DPU,DSH,DSV,POR,PPU,PSH,PSV,UNT,ZZZ,")]
    public class X12_ID_653
    {
    }
    
    /// <summary>
    /// Discount Base Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CA,PC,UN,ZZ,")]
    public class X12_ID_654
    {
    }
    
    /// <summary>
    /// Discount Control Limit Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DAT,DOF,")]
    public class X12_ID_656
    {
    }
    
    /// <summary>
    /// Basis of Verification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,")]
    public class X12_ID_659
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,53,54,55,56,57,58,59,6,61,62,63,64,7,71,72,73,74,75,76,77,78,8,81,82,9,90,91,92,93,94,95,96,97,98,99,A,A1,A2,A3,A4,A5,A6,AA,AB,AC,AD,AE,AL,AP,BC,BD,BE,BG,BP,BS,C,C1,C2,C5,CA,CB,CC,CD,CE,CF,CI,CL,CM,CP,CR,CS,CT,D,DG,DL,DN,DP,DS,E,EC,EH,EI,EP,EQ,ER,ES,F,FA,FB,FC,FD,FI,FJ,FN,G,GA,GC,HC,HN,I,J,K,L,LC,LD,LE,LI,LN,M3,M4,M5,M6,MA,MB,MC,MD,MI,MK,ML,MN,MP,MR,N,NA,ND,NI,NO,OC,OP,PA,PB,PC,PI,PP,PR,RA,RB,RC,RD,RE,RT,S,SA,SB,SD,SF,SI,SJ,SL,SP,ST,SV,SW,TA,TC,TZ,UC,UL,UM,UP,UR,US,WR,XV,XX,ZC,ZN,ZY,ZZ,")]
    public class X12_ID_66
    {
    }
    
    /// <summary>
    /// Relationship Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,I,O,S,")]
    public class X12_ID_662
    {
    }
    
    /// <summary>
    /// Currency Market/Exchange Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",IMF,LNF,LNS,NYC,PHI,ZUR,")]
    public class X12_ID_669
    {
    }
    
    /// <summary>
    /// Quantity Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H" +
        ",1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,20,21,22,23,24,25,26,27,2" +
        "8,29,2A,2B,2C,2D,2E,2F,2G,2H,2I,2J,2K,2L,2M,2N,2O,2P,2Q,2R,2S,2T,2U,2V,2W,2X,2Y," +
        "2Z,30,31,32,33,34,35,36,37,38,39,3A,3B,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3P,3Q" +
        ",3R,3S,3T,3U,3V,3W,3X,3Y,40,41,42,43,45,46,47,48,49,4A,4B,4C,4D,4E,4F,4G,4H,4I,4" +
        "J,4K,4L,4M,4N,4O,4P,4Q,4R,4S,4T,4U,50,51,52,53,54,55,56,57,58,5A,5B,5C,5D,5E,5F," +
        "5G,5H,5I,5J,5K,5L,5M,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z,60,61,62,63,64,65,66" +
        ",67,68,69,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R,6S,6T,6U,6V,6W,6" +
        "X,6Z,70,72,73,74,75,76,77,78,79,7A,7B,7C,7D,7E,7F,7G,7H,7I,7J,7K,7L,7M,7N,7O,7P," +
        "7Q,7R,7S,7T,7U,7V,7W,7X,7Y,7Z,80,81,82,83,84,85,86,87,88,89,8A,8B,8C,8D,8E,8F,8G" +
        ",8H,8I,8J,8K,8L,8M,8N,8O,8P,8Q,8R,8S,90,91,92,93,94,95,96,97,98,99,9A,9C,9D,9E,9" +
        "F,9H,9J,9K,9L,9M,9N,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK," +
        "AL,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B7,B8,BA,BB,BC,BD,BE" +
        ",BF,BG,BH,BI,BJ,BK,BQ,BR,BW,C0,CA,CB,CC,CD,CE,CF,CG,CH,CI,CL,CN,CO,CP,CR,CS,CW,C" +
        "Y,CZ,D1,D3,DA,DB,DC,DD,DE,DF,DG,DI,DN,DO,DP,DR,DS,DT,DY,E1,E2,E3,E4,E5,EA,EB,EC," +
        "ED,EE,EM,EP,EQ,ER,ES,ET,EW,F1,FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ,FK,FL,FM,FR,FS,FT,GA" +
        ",GB,GC,GE,GF,GI,GL,GP,GQ,GR,GS,GT,GU,GV,GW,GX,GZ,HA,HB,HC,HD,HE,HF,HG,HH,HI,HJ,H" +
        "K,HL,HM,HN,HO,HP,HR,HS,II,IN,IP,IQ,IS,IT,JA,JB,JC,JD,JE,JF,JG,JH,JI,JJ,JK,JL,JM," +
        "JN,JO,JP,JQ,JR,JS,JT,K6,KA,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS" +
        ",KU,KV,KW,KX,KY,KZ,L2,L3,L4,L5,L6,L7,LA,LB,LC,LE,LG,LH,LI,LK,LL,LM,LN,LO,LP,LQ,L" +
        "R,LS,LT,LV,LW,LX,LY,M1,M2,MA,MD,ME,MF,MI,MM,MN,MO,MQ,MX,N1,N2,N3,N4,N5,N6,NA,NB," +
        "NC,ND,NE,NF,NG,NL,NN,NO,NP,NQ,NR,NS,NT,NU,NV,NW,OC,OD,OF,OG,OH,OI,OL,ON,OO,OR,OT" +
        ",OU,OV,OW,P1,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,PK,PL,PO,PP,PQ,PR,PS,PT,P" +
        "W,PX,Q1,Q2,Q3,Q4,QA,QB,QC,QD,QE,QF,QH,QI,QJ,QL,QM,QN,QO,QP,QQ,QR,QS,QU,QV,QW,QX," +
        "R3,R5,R6,R9,RA,RB,RC,RD,RE,RF,RG,RH,RJ,RL,RM,RN,RQ,RS,RT,RW,RY,S1,S2,S3,S4,S5,S6" +
        ",S7,S8,S9,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,S" +
        "X,SY,T1,T2,T3,T4,T5,T6,T7,TA,TB,TC,TD,TE,TG,TH,TI,TJ,TK,TM,TN,TO,TP,TR,TS,TT,TU," +
        "TV,TW,TX,TY,UA,UG,UL,UO,US,UU,V1,V2,V3,V4,V5,VA,VB,VC,VD,VE,VF,VG,VH,VI,VJ,VK,VL" +
        ",VM,VN,VP,VR,VS,VT,VV,VY,WA,WB,WC,WD,WE,WG,WL,WO,WP,WR,WT,WV,WW,WX,WY,X1,XA,XB,X" +
        "C,XD,XE,XG,XI,XJ,XL,XN,XO,XT,XU,XV,XX,XY,XZ,YA,YB,YC,YD,YE,YF,YG,YH,YJ,YK,YL,YM," +
        "YN,YP,YQ,YR,YS,YT,YW,YX,YY,Z1,Z2,Z3,Z4,Z6,ZA,ZB,ZC,ZD,ZE,ZF,ZG,ZH,ZI,ZJ,ZK,ZL,ZM" +
        ",ZN,ZO,ZP,ZR,ZS,")]
    public class X12_ID_673
    {
    }
    
    /// <summary>
    /// Class of Trade Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AG,AI,AP,AS,BG,BR,CB,CN,CO,CR,CX,CY,DE,DF,DI,DR,EX,FS,GA,GM,GR,GV,HS" +
        ",ID,IN,IR,JB,LC,MC,MF,ML,OE,OF,ON,PF,PH,PT,PY,RS,SA,SB,SE,ST,TR,WA,WC,WH,WS,")]
    public class X12_ID_687
    {
    }
    
    /// <summary>
    /// Restrictions/Conditions Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,DO,DW,NR,NS,OR,SP,SR,WO,")]
    public class X12_ID_688
    {
    }
    
    /// <summary>
    /// Paperwork/Report Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,CH,CO,DM,NT,ON,OR,PV,SG,")]
    public class X12_ID_704
    {
    }
    
    /// <summary>
    /// Entity Relationship Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,")]
    public class X12_ID_706
    {
    }
    
    /// <summary>
    /// Transit Direction Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BS,SB,SC,SD,SF,SS,ZZ,")]
    public class X12_ID_731
    {
    }
    
    /// <summary>
    /// Transit Time Direction Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AD,CD,CW,HO,SD,SH,WD,WW,ZZ,")]
    public class X12_ID_732
    {
    }
    
    /// <summary>
    /// Measurement Reference ID Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",9L,AA,AB,AC,AE,AF,AG,AH,AI,AJ,AK,AM,AN,AO,AP,AQ,AR,AV,BA,BB,BC,BD,BL,BM,BN,BO,BP,BR,BT,BZ,C1,CA,CB,CC,CF,CG,CH,CJ,CK,CL,CM,CN,CO,CP,CQ,CS,CT,CU,CV,CW,CY,DE,DN,DT,EA,EE,EF,EL,EN,FC,FD,FH,FJ,FV,FZ,GC,GL,GO,GP,HC,HR,ID,IN,IR,LC,LD,LG,LL,LM,LP,LS,LT,MP,MR,NC,NE,NX,OD,OG,OL,OP,P1,PA,PB,PC,PD,PI,PJ,PK,PL,PM,PO,PR,PS,PT,PU,PY,QR,QV,R1,R2,RA,RG,RL,RN,RO,RP,RQ,RS,RT,SA,SB,SC,SD,SE,SF,SH,SJ,SK,SL,SM,SP,SR,ST,SU,SZ,TA,TD,TE,TI,TL,TO,TP,TR,TS,TT,VT,WA,WR,WT,ZA,ZP,")]
    public class X12_ID_737
    {
    }
    
    /// <summary>
    /// Measurement Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,18,19,1F,2,20,21,22,23,24,25,26,27,28,29,2F,3,30,31,32,33" +
        ",34,35,36,37,38,39,3A,3B,3C,3D,3E,3F,3G,3H,3I,3J,4,40,41,42,43,44,4F,5,5F,6,6F,7" +
        ",8,8F,A,A1,A2,A3,A4,A5,A6,A7,A9,AA,AAP,AB,ABO,ABR,ABS,AC,ACN,AD,ADH,ADM,AE,AF,AG" +
        ",AGE,AGI,AH,AI,AJ,AK,AL,ALK,ALN,ALP,AM,AMI,AMW,AN,AOX,AP,API,APP,AS,ASH,ASY,AT,A" +
        "U,AV,AVT,AW,AX,AY,AZ,B,B1,B2,B3,B4,B5,B6,BA,BB,BC,BD,BDP,BE,BF,BG,BH,BHF,BHS,BIC" +
        ",BJ,BK,BL,BN,BND,BO,BOR,BP,BQ,BR,BRS,BSW,BT,BU,BUD,BW,BX,C,C0,C1,C2,C3,C4,CA,CAU" +
        ",CC,CCF,CCG,CD,CE,CF,CG,CGR,CH,CHA,CHC,CHG,CHL,CI,CIV,CJ,CK,CL,CLA,CLB,CLN,CM,CN" +
        ",CO,COH,COL,CON,COR,COS,COT,CP,CPF,CPS,CQ,CR,CRF,CRL,CRN,CRT,CS,CSC,CSR,CST,CT,C" +
        "TG,CTT,CU,CUT,CW,CWT,CX,CY,CYB,D,D1,D2,D3,D4,D5,D7,DA,DAT,DB,DC,DCT,DD,DE,DEM,DF" +
        ",DG,DH,DI,DIR,DIS,DJ,DL,DM,DME,DMF,DN,DP,DPM,DR,DRY,DS,DT,DU,DW,DWP,DY,E,E0,E1,E" +
        "A,EB,EC,ED,EE,EF,EG,EH,EI,EJ,EL,ELC,ELE,ELI,ELL,ELO,ELP,ELS,ELT,ELV,ELW,ELX,EM,E" +
        "N,EP,EPL,ES,EVL,EVR,EW,EX,EXH,EXT,F,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA,FB,FBP,FC,FD,F" +
        "E,FF,FG,FH,FI,FIL,FIN,FIT,FJ,FK,FL,FLD,FLN,FLP,FLV,FML,FMZ,FN,FNL,FNS,FOA,FOH,FO" +
        "I,FOR,FP,FPV,FQ,FR,FS,FSI,FT,FU,FUD,FV,FW,FX,FY,FZ,G,G1,G2,G3,G4,GA,GB,GC,GD,GE," +
        "GEL,GF,GG,GGR,GH,GI,GIR,GJ,GK,GL,GLE,GM,GN,GO,GOR,GP,GQ,GR,GRA,GRI,GS,GT,GW,H1,H" +
        "2O,H8,H9,HA,HAR,HAZ,HB,HC,HCG,HD,HE,HF,HG,HH,HHW,HI,HIB,HJ,HK,HL,HM,HO,HOC,HP,HR" +
        ",HT,HTE,HVM,HWS,HYD,HZ,HZC,I,IA,IB,IC,ID,IDE,IE,IF,IG,IGA,IGR,IH,IHV,II,IJ,IK,IL" +
        ",IM,IMP,IN,IND,INS,IO,IP,IPI,IQ,IR,IRA,IS,IT,IU,IV,IW,IX,IY,IZ,JA,JOM,KA,KB,KN,L" +
        ",L0,L1,LA,LAI,LB,LC,LC5,LCG,LD,LD5,LDH,LE,LEF,LF,LG,LIR,LIV,LL,LLD,LM,LN,LO,LOI," +
        "LOS,LOW,LP,LPG,LPL,LPR,LS,LSK,LSS,LT,LTD,LW,M,M1,M2,M3,M4,M5,M6,MA,MAT,MB,MC,MCN" +
        ",MD,ME,MEF,MEL,MER,MF,MG,MH,MHI,MI,MIC,MJ,MK,MM,MN,MO,MOI,MOR,MP,MPR,MQ,MR,MS,MT" +
        ",MTD,MU,MUL,MV,MW,MX,MY,N,NA,NB,NC,ND,NEU,NF,NG,NH,NI,NIL,NJ,NK,NL,NM,NNW,NO,NOC" +
        ",NON,NOR,NOX,NP,NS,NU,NV,O,O1,OA,OAP,OB,OBT,OC,OCG,OCR,OD,ODR,OE,OF,OG,OH,OI,OIL" +
        ",OJ,OK,OL,OLE,OM,ON,OO,OP,OQ,OR,ORC,OS,OT,OTE,OTH,OTT,OV,OW,OX,OXI,OXS,OY,P1,PA," +
        "PAR,PB,PBD,PC,PD,PDE,PDG,PE,PER,PF,PFO,PG,PH,PHA,PHW,PI,PIC,PJ,PK,PL,PM,PN,PO,PO" +
        "C,POD,POP,PP,PPS,PQ,PR,PRE,PRF,PRI,PRL,PRO,PRQ,PRY,PS,PSA,PSP,PSW,PT,PU,PV,PW,PW" +
        "A,PWE,PWF,PX,PY,PZ,Q,QA,QB,QC,QD,QE,QF,QL,QUR,R,R1,R10,R18,R2,R3,R4,R7,R8,RA,RAD" +
        ",RAF,RB,RC,RD,RE,REA,RED,REF,REI,REL,RES,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,ROH,ROX,R" +
        "P,RQ,RR,RS,RSZ,RT,RTB,RU,RUD,RV,RVP,RW,RX,RY,S,S1,S10,S12,S18,S2,S3,S4,S5,S6,S7," +
        "S8,S9,SA,SAP,SB,SC,SCH,SD,SE,SEV,SF,SG,SH,SHA,SI,SIL,SJ,SK,SL,SLD,SLI,SM,SMB,SMD" +
        ",SN,SO,SOD,SOF,SP,SPG,SPR,SQ,SR,SS,ST,STA,STL,STP,SU,SUM,SUR,SUT,SV,SVL,SW,SX,SX" +
        "X,SY,SZ,T,T1,T2,T3,T4,T5,T50,T90,TA,TAS,TB,TC,TCL,TD,TDP,TE,TEE,TES,TEX,TF,TG,TH" +
        ",TI,TJ,TK,TL,TM,TN,TO,TOA,TOR,TOX,TP,TPF,TPL,TPQ,TPS,TQ,TR,TRA,TRC,TRD,TRN,TS,TS" +
        "Z,TT,TTL,TU,TUR,TV,TVD,TW,TWD,TX,TY,U,UA,UCB,UG,UNI,UNK,VAD,VAP,VCG,VH,VIN,VIS,V" +
        "O,VOC,VOL,VOT,VOV,VOW,VSO,VW,VWT,WA,WB,WC,WD,WDE,WE,WEL,WF,WH,WI,WL,WM,WOD,WPF,W" +
        "PL,WPS,WR,WRA,WSK,WT,WTB,WU,WX,X,XA,XH,XP,XQ,XZ,YA,YB,YC,YD,ZA,ZAL,ZAS,ZB,ZBI,ZB" +
        "T,ZBZ,ZC,ZCA,ZCB,ZCD,ZCE,ZCO,ZCR,ZCU,ZD,ZET,ZF,ZFE,ZFL,ZFS,ZG,ZGE,ZH,ZHP,ZHS,ZHX" +
        ",ZIB,ZIP,ZMG,ZMN,ZMO,ZMT,ZN,ZNB,ZNI,ZNP,ZO,ZOC,ZP,ZPB,ZPP,ZPT,ZR,ZS,ZSB,ZSE,ZSI," +
        "ZSN,ZTA,ZTB,ZTE,ZTI,ZV,ZW,ZZN,ZZR,ZZZ,")]
    public class X12_ID_738
    {
    }
    
    /// <summary>
    /// Product/Process Characteristic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,25,28,29,30,32,33,34,35,36,37,38,39,40,41,42,43,54,55,56,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,99,9A,9B,9C,9D,AF,AG,AGE,AT,B8,BC,BCC,BES,BEV,BLM,BND,BPI,BRG,BW,C2,C3,C4,C5,C6,CCN,CD,CFC,CH,CHF,CL,CLT,CM,CMS,CO,CP,CS,CU,CW,DAC,DAF,DE,DF,DIR,DM,EC,EN,FA,FC,FCD,FDD,FL,FLV,FMR,FQ,GD,GEN,GM,GS,HB,HY,HZ,HZR,ING,INJ,KI,LC,LO,MA,MAC,MB,MBU,MS,MSG,NH,OC,OD,ODR,OR,OT,P6,PD,PF,PFA,PFC,PFG,PFI,PFK,PFL,PFM,PFN,PFP,PFS,PFT,PG,PP,PR,PRI,PRO,PSC,PUB,PUR,QAS,R3,RA,RCC,RM,RR,RSD,RSE,RX,SC,SE,SEC,SF,SIZ,SLM,SOL,ST,STL,SYN,TC,TE,TF,THR,TIF,TIR,TP,TR,TRN,TWF,TZ,VA,VC,VI,WD,WF,WLC,WT,WTT,ZZ,")]
    public class X12_ID_750
    {
    }
    
    /// <summary>
    /// Surface/Layer/Position Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1S,2S,A1,AL,AO,AS,B1,BC,BI,BK,BL,BR,BS,BT,CH,CT,DO,DT,DU,EX,FR,FS,GF,IN,IT,KB,LC,LO,LT,M1,MC,MD,NS,NT,OA,OS,OT,R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SN,SP,SS,ST,SU,TB,TP,TS,UC,UN,UP,UT,WF,")]
    public class X12_ID_752
    {
    }
    
    /// <summary>
    /// Packaging Characteristic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,10,11,12,13,34,35,36,37,38,39,40,42,43,44,45,60,61,62,63,65,66,67,68,CB,CC,CD" +
        ",CS,CT,CUD,HM,IC,IP,LP,OPI,PK,PM,PML,PN,SMK,UC,UCL,UP,WM,")]
    public class X12_ID_753
    {
    }
    
    /// <summary>
    /// Report Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,5" +
        "4,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80," +
        "81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,A1,A2,A3,A4,AA,AB,AC,AD,AE,AF" +
        ",AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,BA,BB,B" +
        "C,BE,BF,BL,BM,BN,BO,BR,BS,BT,BW,BY,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF," +
        "CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CW,CX,CY,CZ,D2,DA,DB,DC,DD,DE,DF,DG" +
        ",DH,DI,DJ,DK,DL,DM,DN,DQ,DR,DS,DT,DU,DV,DW,E1,EA,EB,EC,ED,EL,EP,ER,EX,EY,F1,F2,F" +
        "3,F4,F5,F6,F7,F8,F9,FB,FC,FD,FE,FH,FI,FM,FS,GP,GT,HC,HR,HW,I2,I3,I4,I5,I6,IA,IC," +
        "IM,IN,IP,IR,IS,IT,IU,IV,JA,JB,JC,JD,JE,JF,JG,JH,JI,JK,JL,JM,JN,JO,JP,JQ,JR,JS,JT" +
        ",JV,JW,JX,JY,JZ,KA,KC,KD,KE,KF,KG,KH,KI,KJ,KY,KZ,LA,LB,LC,LD,LE,LG,LI,LO,LP,LR,L" +
        "S,LT,LW,M1,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MV,MZ,NA," +
        "NC,ND,NI,NL,NM,NN,NO,NQ,NR,NT,OB,OC,OD,OE,OL,OP,OR,OS,OT,OX,OZ,P1,P2,P3,P4,P5,P6" +
        ",P7,P8,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PV,PW,PX,PY,P" +
        "Z,QC,QD,QE,QM,QR,QS,QT,R1,R2,R3,R4,R5,R6,RA,RB,RC,RD,RE,RF,RG,RM,RN,RO,RR,RT,RV," +
        "RX,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SG,SH,SI,SL,SM,SN,SO,SP,SQ,SR,SS" +
        ",ST,SU,SV,SW,SX,SY,T1,T2,T3,T4,T5,T6,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,T" +
        "O,TP,TQ,TR,TS,TT,TX,U1,UA,UB,UD,UE,UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,UR,US,UT," +
        "UU,UV,UX,UY,UZ,V1,V2,V3,V4,V5,V6,V7,VA,VC,VD,VM,W1,W2,WA,WB,WC,WD,WE,WF,WG,WH,WI" +
        ",WP,WT,X1,X2,X3,X4,X5,XE,XP,Y1,Y2,Y3,ZA,ZB,ZZ,")]
    public class X12_ID_755
    {
    }
    
    /// <summary>
    /// Report Transmission Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,AA,AC,AE,AM,AS,AT,AU,BE,BM,BW,CD,CF,CP,CT,DA,EL,EM,FT,FX,GS,HL" +
        ",IA,IE,IM,MB,MD,MN,MP,MT,NS,OL,PO,SE,SM,SN,SW,TA,TE,TM,TX,VO,WS,")]
    public class X12_ID_756
    {
    }
    
    /// <summary>
    /// Security Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,09,11,20,21,90,92,93,94,99,ZZ,")]
    public class X12_ID_786
    {
    }
    
    /// <summary>
    /// Entity Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,J,K,L,M,N,P,Z,")]
    public class X12_ID_792
    {
    }
    
    /// <summary>
    /// Vessel Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BC,BD,BI,BK,BL,BO,CB,CT,DG,DP,FH,GC,GT,MT,PC,PS,RR,SP,TG,VH,")]
    public class X12_ID_854
    {
    }
    
    /// <summary>
    /// Marks and Numbers Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AI,CA,CP,DZ,GM,L,MC,PB,R,S,SI,SM,SR,SS,UC,UP,W,X,ZZ,")]
    public class X12_ID_88
    {
    }
    
    /// <summary>
    /// Vessel Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,C,L,Z,")]
    public class X12_ID_897
    {
    }
    
    /// <summary>
    /// Transportation Method/Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",6,7,A,AC,AE,AF,AH,AR,B,BP,BU,C,CE,D,DA,DW,E,ED,F,FA,FL,GG,GR,GS,H,HH,I,J,K,L,LA," +
        "LT,M,MB,MP,N,O,P,PA,PG,PL,PP,PR,PT,Q,R,RC,RR,S,SB,SC,SD,SE,SR,SS,ST,T,TA,TC,TT,U" +
        ",VA,VE,VL,W,WP,X,Y,Y1,Y2,ZZ,")]
    public class X12_ID_91
    {
    }
    
    /// <summary>
    /// Purchase Order Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AC,AO,BD,BE,BH,BK,BL,BQ,BY,CA,CC,CF,CN,CO,CP,CR,DR,DS,EO,FH,IN,JL,KA,KB,KC,KD" +
        ",KE,KG,KI,KN,KO,KP,KQ,KR,KS,KT,LB,LS,NE,NO,NP,NS,OS,PR,RA,RC,RE,RL,RN,RO,RR,RT,R" +
        "U,RW,SA,SO,SP,SS,ST,SW,TC,TM,TR,UD,UE,US,WO,ZZ,")]
    public class X12_ID_92
    {
    }
    
    /// <summary>
    /// Printer Carriage Control Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AT,DS,LC,NP,NS,SS,")]
    public class X12_ID_934
    {
    }
    
    /// <summary>
    /// Measurement Significance Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,34,35,36,37,38,39,40,41,42,43,44,45,46,47,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,ZZ,")]
    public class X12_ID_935
    {
    }
    
    /// <summary>
    /// Measurement Attribute Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,40,41,42,44,45,46,48,49,50,51,52,Q1,Q2,TA,TB,ZZ,")]
    public class X12_ID_936
    {
    }
    
    /// <summary>
    /// Balance Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,AM,C,CD,M,N,P,Q,Y,")]
    public class X12_ID_951
    {
    }
    
    /// <summary>
    /// Tax Jurisdiction Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CD,VD,VE,")]
    public class X12_ID_955
    {
    }
    
    /// <summary>
    /// Tax Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AT,BP,CA,CB,CG,CI,CP,CR,CS,CT,CV,DL,EQ,ET,EV,F1,F2,F3,FD,FF,FI,FL,FR,FS,FT" +
        ",GR,GS,HS,HT,HZ,LB,LO,LS,LT,LU,LV,MA,MN,MP,MS,MT,OH,OT,PG,PS,SA,SB,SC,SE,SF,SL,S" +
        "P,SR,SS,ST,SU,SX,T1,T2,TD,TT,TX,UL,UT,VA,WS,ZA,ZB,ZC,ZD,ZE,ZZ,")]
    public class X12_ID_963
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",001,002,003,004,005,006,007,01,02,03,04,05,06,07,08,09,0A,0B,0D,0E,0F,0H,10,11,1" +
        "2,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H,1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1S," +
        "1T,1U,1V,1W,1X,1Y,1Z,20,21,22,23,24,25,26,27,28,29,2A,2B,2C,2D,2E,2F,2G,2H,2I,2J" +
        ",2K,2L,2M,2N,2O,2P,2Q,2R,2S,2T,2U,2V,2W,2X,2Y,2Z,30,31,32,33,34,35,36,37,38,39,3" +
        "A,3B,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R,3S,3T,3U,3V,3W,3X,3Y,3Z,40," +
        "41,42,43,44,45,46,47,48,49,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4K,4L,4M,4N,4O,4P,4Q,4R" +
        ",4S,4T,4U,4V,4W,4X,4Y,4Z,50,51,52,53,54,55,56,57,58,59,5A,5B,5C,5D,5E,5F,5G,5H,5" +
        "I,5J,5K,5L,5M,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z,60,61,62,63,64,65,66,67,68," +
        "69,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R,6S,6T,6U,6V,6W,6X,6Y,6Z" +
        ",70,71,72,73,74,75,76,77,78,79,7A,7B,7C,7D,7E,7F,7G,7H,7I,7J,7K,7L,7M,7N,7O,7P,7" +
        "Q,7R,7S,7T,7U,7V,7W,7X,7Y,7Z,80,81,82,83,84,85,86,87,88,89,8A,8B,8C,8D,8E,8F,8G," +
        "8H,8I,8J,8K,8L,8M,8N,8O,8P,8Q,8R,8S,8T,8U,8V,8W,8X,8Y,8Z,90,91,92,93,94,95,96,97" +
        ",98,99,9A,9B,9C,9D,9E,9F,9G,9H,9I,9J,9K,9L,9N,9O,9P,9Q,9R,9S,9T,9U,9V,9W,9X,9Y,9" +
        "Z,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL," +
        "AAM,AAN,AAO,AAP,AAQ,AAS,AAT,AAU,AAV,AB,ABB,ABC,ABD,ABE,ABF,ABG,ABH,ABI,ABJ,ABK,A" +
        "BL,ABM,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,ALA,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY," +
        "AZ,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BAL,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BKR,BL,BM,BN," +
        "BO,BP,BQ,BR,BRN,BS,BT,BU,BUS,BV,BW,BX,BY,BZ,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC," +
        "CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CMW,CN,CO,COL,COR,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ" +
        ",D1,D2,D3,D4,D5,D6,D7,D8,D9,DA,DB,DC,DCC,DD,DE,DF,DG,DH,DI,DIR,DJ,DK,DL,DM,DN,DO" +
        ",DP,DQ,DR,DS,DT,DU,DV,DW,DX,DY,DZ,E1,E2,E3,E4,E5,E6,E7,E8,E9,EA,EB,EC,ED,EE,EF,E" +
        "G,EH,EI,EJ,EK,EL,EM,EN,ENR,EO,EP,EQ,ER,ES,ET,EU,EV,EW,EX,EXS,EY,EZ,F1,F2,F3,F4,F" +
        "5,F6,F7,F8,F9,FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ,FL,FM,FN,FO,FP,FQ,FR,FRL,FS,FSR,FT,F" +
        "U,FV,FW,FX,FY,FZ,G0,G1,G2,G3,G5,G6,G7,G8,G9,GA,GB,GC,GD,GE,GF,GG,GH,GI,GIR,GJ,GK" +
        ",GL,GM,GN,GO,GP,GQ,GR,GS,GT,GU,GV,GW,GX,GY,GZ,H1,H2,H3,H5,H6,H7,H8,H9,HA,HB,HC,H" +
        "D,HE,HF,HG,HH,HI,HJ,HK,HL,HM,HMI,HN,HO,HOM,HP,HQ,HR,HS,HT,HU,HV,HW,HX,HY,HZ,I1,I" +
        "3,I4,I9,IA,IAA,IAC,IAD,IAE,IAF,IAG,IAH,IAI,IAK,IAL,IAM,IAN,IAO,IAP,IAQ,IAR,IAS,I" +
        "AT,IAU,IAV,IAW,IAY,IAZ,IB,IC,ID,IE,IF,II,IJ,IK,IL,IM,IN,INV,IO,IP,IQ,IR,IS,IT,IU" +
        ",IV,J1,J2,J3,J4,J5,J6,J7,J8,J9,JA,JB,JC,JD,JE,JF,JG,JH,JI,JJ,JK,JL,JM,JN,JO,JP,J" +
        "Q,JR,JS,JT,JU,JV,JW,JX,JY,JZ,K1,K2,K3,K4,K5,K6,K7,K8,K9,KA,KB,KC,KD,KE,KF,KG,KH," +
        "KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS,KT,KU,KV,KW,KX,KY,KZ,L1,L2,L3,L5,L8,L9,LA,LB,LC" +
        ",LD,LE,LF,LG,LGS,LH,LI,LJ,LK,LL,LM,LN,LO,LP,LQ,LR,LS,LT,LU,LV,LW,LY,LYM,LYN,LYO," +
        "LYP,LZ,M1,M2,M3,M4,M5,M6,M7,M8,M9,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,M" +
        "P,MQ,MR,MS,MSC,MT,MU,MV,MW,MX,MY,MZ,N1,N2,N3,N4,N5,N6,N7,N8,N9,NB,NC,NCT,ND,NE,N" +
        "F,NG,NH,NI,NJ,NK,NL,NM,NN,NP,NPC,NQ,NR,NS,NT,NU,NV,NW,NX,NY,NZ,O1,O2,O3,O4,O5,O6" +
        ",O7,O8,OA,OB,OC,OD,OE,OF,OG,OH,OI,OK,OL,OM,ON,OO,OP,OR,ORI,OS,OT,OU,OV,OW,OX,OY," +
        "OZ,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PLR,PM,PMF," +
        "PN,PO,PP,PPS,PQ,PR,PRE,PRP,PS,PT,PU,PUR,PV,PW,PX,PY,PZ,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q" +
        "9,QA,QB,QC,QD,QE,QF,QG,QH,QI,QJ,QK,QL,QM,QN,QO,QP,QQ,QR,QS,QT,QU,QV,QW,QX,QY,QZ," +
        "R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RCR,RD,RE,REC,RF,RG,RGA,RH,RI,RJ,RK,RL,RM" +
        ",RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,S0,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,S" +
        "D,SE,SEP,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SX,SY,SZ,T1,T2,T3" +
        ",T4,T6,T8,T9,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TPM,TQ,TR,TS,TSE,TS" +
        "R,TT,TTP,TU,TV,TW,TX,TY,TZ,U1,U2,U3,U4,U5,U6,U7,U8,U9,UA,UB,UC,UD,UE,UF,UG,UH,UI" +
        ",UJ,UK,UL,UM,UN,UO,UP,UQ,UR,US,UT,UU,UW,UX,UY,UZ,V1,V2,V3,V4,V5,V6,V8,V9,VA,VB,V" +
        "C,VD,VE,VF,VG,VH,VI,VJ,VK,VL,VM,VN,VO,VP,VQ,VR,VS,VT,VU,VV,VW,VX,VY,VZ,W1,W2,W3," +
        "W4,W8,W9,WA,WB,WC,WD,WE,WF,WG,WH,WI,WJ,WL,WN,WO,WP,WR,WS,WT,WU,WV,WW,WX,WY,WZ,X1" +
        ",X2,X3,X4,X5,X6,X7,X8,XA,XC,XD,XE,XF,XG,XH,XI,XJ,XK,XL,XM,XN,XO,XP,XQ,XR,XS,XT,X" +
        "U,XV,XW,XX,XY,XZ,Y2,YA,YB,YC,YD,YE,YF,YG,YH,YI,YJ,YK,YL,YM,YN,YO,YP,YQ,YR,YS,YT," +
        "YU,YV,YW,YX,YY,YZ,Z1,Z2,Z3,Z4,Z5,Z6,Z7,Z8,Z9,ZA,ZB,ZC,ZD,ZE,ZF,ZG,ZH,ZJ,ZK,ZL,ZM" +
        ",ZN,ZO,ZP,ZQ,ZR,ZS,ZT,ZU,ZV,ZW,ZX,ZY,ZZ,")]
    public class X12_ID_98
    {
    }
    
    [Serializable()]
    [DataContract()]
    public class X12_N0
    {
    }
    
    [Serializable()]
    [DataContract()]
    public class X12_N2
    {
    }
    
    [Serializable()]
    [DataContract()]
    public class X12_R
    {
    }
    
    [Serializable()]
    [DataContract()]
    public class X12_TM
    {
    }
}
