using Newtonsoft.Json;
namespace csharp
{
    /// <summary>
    /// 앱 세팅 정보
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// WCK 백오피스 인증정보 쿠키명
        /// </summary>
        public string WCKAdminAuthCookie { get; set; }
        /// <summary>
        /// WCK PIN 인증정보 쿠키명
        /// </summary>
        public string WCKPINAuthCookie { get; set; }
        /// <summary>
        /// BranchCD
        /// </summary>
        public string BranchCD { get; set; }
        /// <summary>
        /// DB 컨넥션 정보
        /// </summary>
        public DBConnection DBConnection { get; set; }
        /// <summary>
        /// URL 정보
        /// </summary>
        public BaseUrls BaseUrls { get; set; }
        /// <summary>
        /// URL Host 정보
        /// </summary>
        public UrlHost UrlHost { get; set; }
        /// <summary>
        /// 접근가능 ip
        /// </summary>
        public string AllowIP { get; set; }
        /// <summary>
        /// 다량 Email 메시지 승인 중 테스트메일 발송 가능 ip
        /// </summary>
        public string AllowIP_PopupEmailMassInputAgree { get; set; }
        /// <summary>
        /// 외부IP(로그인시 SessionString 만들때사용)
        /// </summary>
        public string PublicIP_SessionString { get; set; }
        /// <summary>
        /// physical directory 정보
        /// </summary>
        public PhysicalDirectory PhysicalDirectory { get; set; }
        /// <summary>
        /// 저장소 정보
        /// </summary>
        public PathInfo PathInfo { get; set; }
        /// <summary>
        /// CON_ 정보
        /// </summary>
        public CONInfo CONInfo { get; set; }
        /// <summary>
        /// 샵엔 상품 api 연동 정보
        /// </summary>
        public ShopNProductAPI ShopNProductAPI { get; set; }
        /// <summary>
        /// Default Message
        /// </summary>
        public SMSMessage SMSMessage { get; set; }

        public Payment Payment { get; set; }
        /// <summary>
        /// 나이스 다큐
        /// </summary>
        public NICEDocu NICEDocu { get; set; }
        /// <summary>
        /// 굿스 플로어
        /// </summary>
        public Goodsflow Goodsflow { get; set; }
        /// <summary>
        /// 바로빌
        /// </summary>
        public Barobill Barobill{get;set;}

        /// <summary>
        /// Babel Transpilied JS 사용여부
        /// </summary>
        [JsonProperty("UseTranspiling")]
        public bool UseTranspiling { get; set; }
    }


    #region 하위 설정값
    /// <summary>
    /// DB 컨넥션 정보
    /// </summary>
    public class DBConnection
    {
        public string WCK { get; set; }
        public string WCKMaria { get; set; }
        public string Log { get; set; }
        public string WCKRead { get; set; }
    }
    /// <summary>
    /// URL 정보
    /// </summary>
    public class BaseUrls
    {
        public string Current { get; set; }
        public string Desktop { get; set; }
        public string Mobile { get; set; }
        public string Cdn { get; set; }
        public string CdnStatic { get; set; }
        public string Classic { get; set; }
        public string ImgUrl { get; set; }              //request.cookies("SCM")("img_url")
        public string ImgProductUrl { get; set; }       //request.cookies("SCM")("img_product_url")
        public string FrontSiteUrl { get; set; }        //request.cookies("SCM")("site_url")
        public string OldPrsUrl { get; set; }
        /// <summary>
        /// pin 사이트 url
        /// </summary>
        public string PinUrl { get; set; }
    }

    /// <summary>
    /// URL Host 정보
    /// </summary>
    public class UrlHost
    {
        public string Desktop { get; set; }
        public string Mobile { get; set; }
    }


    /// <summary>
    /// physical directory 정보
    /// </summary>
    public class PhysicalDirectory
    {
        /// <summary>
        /// 프론트 이미지 절대경로
        /// </summary>
        public string ImgDir {get;set;}     //request.cookies("SCM")("img_dir")

        /// <summary>
        /// 상품이미지 절대경로
        /// </summary>
        public string ImgProductDir { get; set; }       //request.cookies("SCM")("img_product_dir")

        /// <summary>
        ///  이벤트 html 파일 절대 경로
        /// </summary>
        public string EventDir { get; set; }        //request.cookies("SCM")("event_dir")

        /// <summary>
        /// 상세정보 이미지 절대경로
        /// </summary>
        public string TextDir { get; set; }     //request.cookies("scm")("text_dir")

        /// <summary>
        /// 상세정보 이미지 절대경로
        /// </summary>
        public string TextImgDir { get; set; }  //request.cookies("scm")("text_img_dir")	

        /// <summary>
        ///  메인 배너 및 팝업 기초정보 생성용 폴더
        /// </summary>
        public string DefaultDir { get; set; }   //request.cookies("SCM")("default_dir")
        
        public string PushDataDir { get; set; }
    }

    public class PathInfo
    {
        /// <summary>
        /// 아이디
        /// </summary>
        public string LogonID { get; set; }
        /// <summary>
        /// 패스워드
        /// </summary>
        public string LogonPW { get; set; }
    }

    public class CONInfo
    {
        public string customertel { get; set; }
        public string email { get; set; }
    }

    public class ShopNProductAPI
    {
        public string Version { get; set; }
        public string BasicURL { get; set; }
        public string AccessLicense { get; set; }
        public string SecretKey { get; set; }
        public string SellerId { get; set; }
        public string ChkImgURLVal { get; set; }
    }

    public class SMSMessage
    {
        public string MEMB_IN { get; set; }
        public string MEMB_OUT { get; set; }
        public string MEMB_PWD { get; set; }
        public string ORDE_IN { get; set; }
        public string ORDE_CAD { get; set; }
        public string ORDE_BAK { get; set; }
        public string ORDE_SED { get; set; }
        public string ORDE_NPA { get; set; }
        public string ORDE_RPA { get; set; }
        public string CUST_1V1 { get; set; }
        public string CUST_QNA { get; set; }
        public string CANC_SOD { get; set; }
        public string RETU_REV { get; set; }
        public string RETU_COM { get; set; }
        public string RETU_ACC { get; set; }
        public string RELE_SCH { get; set; }
        public string ACCO_CAD { get; set; }
        public string ACCO_RBK { get; set; }
        public string ACCO_YEL { get; set; }
        public string ACCO_BAK { get; set; }
        public string ACCO_DEP { get; set; }
        public string ACCO_MOB { get; set; }
        public string RETU_BAK { get; set; }
        public string CANC_GUI { get; set; }
        public string ORDE_DEL { get; set; }
        public string ORDE_OCA { get; set; }
        public string VND_SMS { get; set; }
        public string MEMB_SMS { get; set; }
    }

    public class Payment
    {
        public Danal Danal { get; set; }
        public KaKao KaKao { get; set; }
        public Smile Smile { get; set; }
        public Payco Payco { get; set; }
        public Toss Toss { get; set; }
    }

    public class Danal
    {
        public string ID { get; set; }
        public string PWD { get; set; }
    }
    public class KaKao
    {
        public string AuthKey { get; set; }
        public string CancelUrl { get; set; }
    }
    public class Smile
    {
        public string AuthKey { get; set; }
        public string ApproveUrl { get; set; }
        public string MID { get; set; }
        public string PW { get; set; }
    }
    public class Payco
    {
        public string ApproveUrl { get; set; }
        public string ApprovePort { get; set; }
        public string LogDir { get; set; }
        public string KeyDir { get; set; }
        public string SiteID { get; set; }
        public string SiteKey { get; set; }
    }
    public class Toss
    {
        public string RefundPayUrl { get; set; }
        public string ApiKey { get; set; }
    }
    /// <summary>
    /// 나이스 다큐
    /// </summary>
    public class NICEDocu
    {
        public string vcd { get; set; }
        public string CertKey_Url { get; set; }
        public string ContactView_Url { get; set; }
    }
    /// <summary>
    /// 굿스 플로어
    /// </summary>
    public class Goodsflow
    {
        public string Api_Key { get; set; }
        public string OTP_Url { get; set; }
        public string ContractDetail_Url { get; set; }
    }
    /// <summary>
    /// 바로빌
    /// </summary>
    public class Barobill
    {
        public string CERTKEY { get; set; }
        public string Wconcept_CorpNum { get; set; }
        public string ContactID { get; set; }
        public string BAROSERVICE_URL_TI { get; set; }
        public string BAROSERVICE_URL_CORPSTATE { get; set; }
    }
    #endregion
}
