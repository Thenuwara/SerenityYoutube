#pragma checksum "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e7cbebd95735669662d76d180a0cda8bca88236"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Membership_Account_AccountLogin_AdminLTE), @"mvc.1.0.view", @"/Modules/Membership/Account/AccountLogin.AdminLTE.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\_ViewImports.cshtml"
using SerenityApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e7cbebd95735669662d76d180a0cda8bca88236", @"/Modules/Membership/Account/AccountLogin.AdminLTE.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cba7e04dba9f18ec3c107d4589ddffd536d51eb", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Membership_Account_AccountLogin_AdminLTE : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/iCheck/square/blue.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.icheck.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
  
    ViewData["Title"] = Texts.Forms.Membership.Login.FormTitle;
    ViewData["PageId"] = "Login";
    ViewData["BodyClass"] = "login-page";
    Layout = MVC.Views.Shared._LayoutNoNavigation;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Head", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5e7cbebd95735669662d76d180a0cda8bca882365545", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e7cbebd95735669662d76d180a0cda8bca882366723", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<script id=""Template_Membership_LoginPanel"" type=""text/template"">
    <div class=""s-Form"">
        <form id=""~_Form"" action="""">            
            <div id=""~_PropertyGrid""></div>
            <div class=""row"">
                <div class=""col-xs-7"">
                    <div class=""checkbox icheck"">
                        <label>
                            <input type=""checkbox""> ");
#nullable restore
#line 21 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
                                               Write(Texts.Forms.Membership.Login.RememberMe);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </label>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-xs-5\">\r\n                    <button id=\"~_LoginButton\" type=\"submit\" class=\"btn btn-primary btn-block btn-flat\">");
#nullable restore
#line 26 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
                                                                                                   Write(Texts.Forms.Membership.Login.SignInButton);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                </div>\r\n            </div>\r\n        </form>\r\n    </div>\r\n</script>\r\n\r\n");
#nullable restore
#line 33 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
 if (DataMigrations.SkippedMigrations)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""alert alert-error alert-dismissible"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">×</button>
    <h4><i class=""icon fa fa-warning""></i> Warning!</h4>
    SerenityApp skipped running migrations to avoid modifying an arbitrary database.
    If you'd like to run migrations on this database, remove the safety check 
    in SiteInitialization.RunMigrations method.
</div>
");
#nullable restore
#line 42 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 44 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
 if (ViewData["Activated"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-info alert-dismissible\">\r\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\r\n    <h4><i class=\"icon fa fa-info\"></i>");
#nullable restore
#line 48 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
                                  Write(LocalText.Get("Dialogs.InformationTitle"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    ");
#nullable restore
#line 49 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
Write(Texts.Forms.Membership.SignUp.ActivationCompleteMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 51 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"login-box\">\r\n    <div class=\"login-logo\">\r\n        ");
#nullable restore
#line 55 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
   Write(Texts.Navigation.SiteTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"login-box-body\">\r\n        <p class=\"login-box-msg\">");
#nullable restore
#line 58 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
                            Write(Texts.Forms.Membership.Login.FormTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <div id=\"LoginPanel\">\r\n        </div>\r\n        <div class=\"social-auth-links text-center\">\r\n            <p>- ");
#nullable restore
#line 62 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
            Write(Texts.Forms.Membership.Login.OR);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -</p>\r\n            <a href=\"#\" class=\"btn btn-block btn-social btn-facebook btn-flat\">\r\n                <i class=\"fa fa-facebook\"></i> ");
#nullable restore
#line 64 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
                                          Write(Texts.Forms.Membership.Login.FacebookButton);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n            <a href=\"#\" class=\"btn btn-block btn-social btn-google btn-flat\">\r\n                <i class=\"fa fa-google-plus\"></i> ");
#nullable restore
#line 67 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
                                             Write(Texts.Forms.Membership.Login.GoogleButton);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n        </div>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 2762, "\"", 2809, 1);
#nullable restore
#line 70 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
WriteAttributeValue("", 2769, Url.Content("~/Account/ForgotPassword"), 2769, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 70 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
                                                      Write(Texts.Forms.Membership.Login.ForgotPassword);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 2875, "\"", 2914, 1);
#nullable restore
#line 71 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
WriteAttributeValue("", 2882, Url.Content("~/Account/SignUp"), 2882, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-center\">");
#nullable restore
#line 71 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
                                                                  Write(Texts.Forms.Membership.Login.SignUpButton);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
    </div>
</div>

<script type=""text/javascript"">
jQuery(function() {
    new SerenityApp.Membership.LoginPanel($('#LoginPanel')).init();
    $('.field.Username,.field.Password').addClass(""has-icon"");
    $('.field.Username input').after(""<span class='glyphicon glyphicon-user form-control-feedback'></span>"");
    $('.field.Password input').after(""<span class='glyphicon glyphicon-lock form-control-feedback'></span>"");
    $('input').iCheck({
        checkboxClass: 'icheckbox_square-blue',
        radioClass: 'iradio_square-blue',
        increaseArea: '20%'
    });
");
#nullable restore
#line 86 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
 if (ViewData["Activated"] != null)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    $(function() { \r\n        $(\'#SerenityApp_Membership_LoginPanel0_Username\').val(");
#nullable restore
#line 90 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
                                                         Write(Html.Raw(Serenity.JSON.Stringify(ViewData["Activated"])));

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n        $(\'#SerenityApp_Membership_LoginPanel0_Password\').focus();\r\n    });\r\n    ");
#nullable restore
#line 93 "D:\HD\Project\YouTube\SerenityYoutube\SerenityApp\SerenityApp\SerenityApp.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
           
}

#line default
#line hidden
#nullable disable
            WriteLiteral("});\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
