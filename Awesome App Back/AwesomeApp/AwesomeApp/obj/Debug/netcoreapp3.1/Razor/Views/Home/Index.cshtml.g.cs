#pragma checksum "C:\Users\User\Desktop\Awesome App Back\AwesomeApp\AwesomeApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa440935195ce0017c0e5c37f2017d1fe2d5a430"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Awesome App Back\AwesomeApp\AwesomeApp\Views\_ViewImports.cshtml"
using AwesomeApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Awesome App Back\AwesomeApp\AwesomeApp\Views\_ViewImports.cshtml"
using AwesomeApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa440935195ce0017c0e5c37f2017d1fe2d5a430", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c07bf483f76811254a7d5f7f1847b98788f784", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/image/phone1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/image/slider1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/image/slider2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/image/slider3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top w-25 rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\User\Desktop\Awesome App Back\AwesomeApp\AwesomeApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <section class=""sec-1"">
        <div class=""container"">
            <div class=""row row-cols-1 row-cols-md-2 g-4 content"">
                <div class=""col"">
                    <h1>Awesome App <br> App Landing Template</h1>
                    <p>
                        An awesome landing page template to showcase your app features, screenshots, pricing, user
                        testimonials and download links.
                    </p>
                    <ul>
                        <li><i class=""las la-check-circle""></i> Amazing Design to Present Your App</li>
                        <li>
                            <i class=""las la-check-circle""></i> Fully Responsive and Powered by Bootstrap & PaperKit
                        </li>
                        <li><i class=""las la-check-circle""></i> Very Easy to Customize and Setup</li>
                    </ul>
                    <button type=""button"" class=""btn btn-outline-light"">START EXPLORING</button>
                </");
            WriteLiteral("div>\r\n                <div class=\"col\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa440935195ce0017c0e5c37f2017d1fe2d5a4307360", async() => {
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
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </section>

    <section class=""mt-5 pt-5 pb-5"">
        <div class=""container"">
            <div class=""row row-cols-1 row-cols-md-3 g-4"">
                <div class=""col"">
                    <div class=""h-100 d-flex flex-row align-items-center"">
                        <div class=""icon"">
                            <i class=""las la-cog""></i>
                        </div>
                        <div class=""card-body"">
                            <h5 class=""card-title"">Showcase Your App</h5>
                            <p class=""card-text"">
                                Showcase your app in style with this professional looking template.
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""h-100 d-flex flex-row align-items-center"">
                        <div class=""icon"">
                     ");
            WriteLiteral(@"       <i class=""las la-cog""></i>
                        </div>
                        <div class=""card-body"">
                            <h5 class=""card-title"">Showcase Your App</h5>
                            <p class=""card-text"">
                                Showcase your app in style with this professional looking template.
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""h-100 d-flex flex-row align-items-center"">
                        <div class=""icon"">
                            <i class=""las la-cog""></i>
                        </div>
                        <div class=""card-body"">
                            <h5 class=""card-title"">Showcase Your App</h5>
                            <p class=""card-text"">
                                Showcase your app in style with this professional looking template.
                            </p>
          ");
            WriteLiteral(@"              </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""h-100 d-flex flex-row align-items-center"">
                        <div class=""icon"">
                            <i class=""las la-cog""></i>
                        </div>
                        <div class=""card-body"">
                            <h5 class=""card-title"">Showcase Your App</h5>
                            <p class=""card-text"">
                                Showcase your app in style with this professional looking template.
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""h-100 d-flex flex-row align-items-center"">
                        <div class=""icon"">
                            <i class=""las la-cog""></i>
                        </div>
                        <div class=""card-body"">
                     ");
            WriteLiteral(@"       <h5 class=""card-title"">Showcase Your App</h5>
                            <p class=""card-text"">
                                Showcase your app in style with this professional looking template.
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""h-100 d-flex flex-row align-items-center"">
                        <div class=""icon"">
                            <i class=""las la-cog""></i>
                        </div>
                        <div class=""card-body"">
                            <h5 class=""card-title"">Showcase Your App</h5>
                            <p class=""card-text"">
                                Showcase your app in style with this professional looking template.
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <div cl");
            WriteLiteral("ass=\"container\">\r\n        <hr>\r\n    </div>\r\n    <section class=\"sec-3 mt-5 pt-5\">\r\n        <div class=\"container\">\r\n            <div class=\"row row-cols-1 row-cols-md-2 g-4\">\r\n                <div class=\"col\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa440935195ce0017c0e5c37f2017d1fe2d5a43013039", async() => {
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
            WriteLiteral(@"
                </div>
                <div class=""col"">
                    <h2>What is Awesome App?</h2>
                    <p>
                        Add a brief story about your app here, what purpose your app solves and why you think your
                        user would want to have it on their device.
                    </p>
                    <p>
                        Re-establish the main use case of your app by listing them below. Make sure to place a
                        relavent screenshot on the left.
                    </p>
                    <ul>
                        <li><i class=""las la-check-circle""></i> Amazing Design to Present Your App</li>
                        <li>
                            <i class=""las la-check-circle""></i> Fully Responsive and Powered by Bootstrap & PaperKit
                        </li>
                        <li><i class=""las la-check-circle""></i> Very Easy to Customize and Setup</li>
                    </ul>
               ");
            WriteLiteral(@"     <button type=""button"" class=""btn btn-outline-light"">START EXPLORING</button>
                </div>

            </div>
        </div>
    </section>

    <section class=""sec-4 mt-5 pt-5 pb-5"">
        <div class=""container"">
            <div class=""title text-center"">
                <h2 class=""pb-4"">Take a look at our screenshots</h2>
                <p class=""pb-5"">
                    Add your app screenshots below. Make sure to make them lively by putting them inside
                    real device mockups <br>
                    Replace this text to describe the screenshots of your app.
                </p>
            </div>
            <div id=""carouselExampleControls"" class=""carousel slide"" data-bs-ride=""carousel"">
                <div class=""carousel-inner"">
                    <div class=""carousel-item active"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa440935195ce0017c0e5c37f2017d1fe2d5a43016123", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"carousel-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa440935195ce0017c0e5c37f2017d1fe2d5a43017428", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"carousel-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa440935195ce0017c0e5c37f2017d1fe2d5a43018733", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
                <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleControls""
                        data-bs-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""visually-hidden"">Previous</span>
                </button>
                <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleControls""
                        data-bs-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""visually-hidden"">Next</span>
                </button>
            </div>
        </div>
    </section>

    <section class=""sec-5 mt-5 pt-5 pb-5 mb-5"">
        <div class=""container"">
            <div class=""title text-center"">
                <h2 class=""pb-4"">We've got the perfect package for you</h2>
                <p class=""pb-5"">
");
            WriteLiteral(@"                    A section to display your pricing structure. Make sure to highlight your most
                    popular plan like shown below. <br>
                    Replace this text to describe your pricing plan.
                </p>
            </div>
            <div class=""row row-cols-1 row-cols-md-2 row-cols-lg-4 g-4"">
                <div class=""col"">
                    <div class=""card h-100 text-center"">
                        <h6 class=""pt-3"">
                            Basic</h>
                            <div class=""card-body p-0"">
                                <h3 class=""card-title pt-4 pb-4"">$12.0/m</h3>
                                <hr>
                                <p>One User</p>
                                <hr>
                                <p>Multiple Access</p>
                                <hr>
                                <p>SMS Support</p>
                                <hr>
                                <p>24/7 Online Support</p>
  ");
            WriteLiteral(@"                              <hr>
                                <p class=""text-muted"">Start Free Trial</p>
                                <button type=""button"" class=""btn btn-outline-dark"">Buy Now</button>
                            </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""card h-100 text-center"">
                        <h6 class=""pt-3"">
                            Standart</h>
                            <div class=""card-body p-0"">
                                <h3 class=""card-title standart pt-4 pb-4"">$24.0/m</h3>
                                <hr>
                                <p>Five User</p>
                                <hr>
                                <p>Multiple Access</p>
                                <hr>
                                <p>SMS Support</p>
                                <hr>
                                <p>24/7 Online Support</p>
                              ");
            WriteLiteral(@"  <hr>
                                <p class=""text-muted"">Start Free Trial</p>
                                <button type=""button"" class=""btn btn-outline-dark standart"">Buy Now</button>
                            </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""card h-100 text-center"">
                        <h6 class=""pt-3"">
                            Premium</h>
                            <div class=""card-body p-0"">
                                <h3 class=""card-title pt-4 pb-4"">$250.0/m</h3>
                                <hr>
                                <p>Twenty User</p>
                                <hr>
                                <p>Multiple Access</p>
                                <hr>
                                <p>SMS Support</p>
                                <hr>
                                <p>24/7 Online Support</p>
                                <hr>
                  ");
            WriteLiteral(@"              <p class=""text-muted"">Start Free Trial</p>
                                <button type=""button"" class=""btn btn-outline-dark"">Buy Now</button>
                            </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""card h-100 text-center"">
                        <h6 class=""pt-3"">
                            Enterprise</h>
                            <div class=""card-body p-0"">
                                <h3 class=""card-title pt-4 pb-4"">$999.0/m</h3>
                                <hr>
                                <p>Unlimited User</p>
                                <hr>
                                <p>Multiple Access</p>
                                <hr>
                                <p>SMS Support</p>
                                <hr>
                                <p>24/7 Online Support</p>
                                <hr>
                                <p class=""text-");
            WriteLiteral(@"muted"">Start Free Trial</p>
                                <button type=""button"" class=""btn btn-outline-dark"">Buy Now</button>
                            </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <div class=""container"">
        <hr>
    </div>

    <section class=""sec-6 mt-5 pt-5 pb-5 mb-5"">
        <div class=""container"">
            <div class=""title text-center"">
                <h2 class=""pb-4"">What our customers are saying</h2>
                <p class=""pb-5"">
                    Real user testimonials are great way to attract new customers and increase their
                    trust into using your app. <br>
                    Replace the testimonials below with the ones for your own app.
                </p>
            </div>
            <div class=""row row-cols-1 row-cols-md-3 g-4"">
");
#nullable restore
#line 294 "C:\Users\User\Desktop\Awesome App Back\AwesomeApp\AwesomeApp\Views\Home\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col\">\r\n                        <div class=\"card h-100\">\r\n                            <div class=\"card-body\">\r\n                                <p class=\"card-text\">\r\n                                   ");
#nullable restore
#line 300 "C:\Users\User\Desktop\Awesome App Back\AwesomeApp\AwesomeApp\Views\Home\Index.cshtml"
                              Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                            <div class=\"user d-flex justify-content-around align-items-center\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa440935195ce0017c0e5c37f2017d1fe2d5a43027200", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 14431, "~/assets/image/", 14431, 15, true);
#nullable restore
#line 304 "C:\Users\User\Desktop\Awesome App Back\AwesomeApp\AwesomeApp\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 14446, item.Image, 14446, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"user-name\">\r\n                                    <h6>");
#nullable restore
#line 306 "C:\Users\User\Desktop\Awesome App Back\AwesomeApp\AwesomeApp\Views\Home\Index.cshtml"
                                   Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <p>");
#nullable restore
#line 307 "C:\Users\User\Desktop\Awesome App Back\AwesomeApp\AwesomeApp\Views\Home\Index.cshtml"
                                  Write(item.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 312 "C:\Users\User\Desktop\Awesome App Back\AwesomeApp\AwesomeApp\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </section>

    <section class=""sec-7 mt-5 pt-5 pb-5"">
        <div class=""container"">
            <div class=""title text-center"">
                <h2 class=""text-white mb-5"">Download Awesome App Now</h2>
            </div>
            <div class=""row row-cols-1 row-cols-md-3 g-4 pb-5"">
                <div class=""col"">
                    <div class=""card h-100 d-flex flex-row justify-content-around align-items-center"">
                        <i class=""lab la-apple""></i>
                        <div class=""card-body"">
                            <h5 class=""card-title"">Download</h5>
                            <p class=""card-text"">Download from App Store</p>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""card h-100 d-flex flex-row justify-content-around align-items-center"">
                        <i class=""lab la-android""></i>
                       ");
            WriteLiteral(@" <div class=""card-body"">
                            <h5 class=""card-title"">Download</h5>
                            <p class=""card-text"">Download from Play Store</p>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""card h-100 d-flex flex-row justify-content-around align-items-center"">
                        <i class=""lab la-windows""></i>
                        <div class=""card-body"">
                            <h5 class=""card-title"">Download</h5>
                            <p class=""card-text"">Download from Microsoft Store</p>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </section>
</main>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591