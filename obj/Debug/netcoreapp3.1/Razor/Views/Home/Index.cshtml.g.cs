#pragma checksum "C:\Users\Hakim\Desktop\Rocket_Elevators_Customer_Portal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58b4abd7c91580be7db728d95d287c0cd43160f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.razor-page", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Hakim\Desktop\Rocket_Elevators_Customer_Portal\Views\_ViewImports.cshtml"
using Customer_Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hakim\Desktop\Rocket_Elevators_Customer_Portal\Views\_ViewImports.cshtml"
using Customer_Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58b4abd7c91580be7db728d95d287c0cd43160f9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5c20769abb6fabd1e65d89915a1feee54dcd53e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-toggle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductManagement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("validate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("php/newsletter.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-success", new global::Microsoft.AspNetCore.Html.HtmlString("Subscribed! Thank you!"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toastr-position", new global::Microsoft.AspNetCore.Html.HtmlString("bottom-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("smoothscroll enable-animation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Hakim\Desktop\Rocket_Elevators_Customer_Portal\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58b4abd7c91580be7db728d95d287c0cd43160f97234", async() => {
                WriteLiteral("\r\n\t\t<meta charset=\"utf-8\" />\r\n\t\t<title>Rocket Elevator</title>\r\n\t\t<meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 209, "\"", 219, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
		<meta name=""Author"" content=""Dorin Grigoras [www.stepofweb.com]"" />

		<!-- mobile settings -->
		<meta name=""viewport"" content=""width=device-width, maximum-scale=1, initial-scale=1, user-scalable=0"" />
		<!--[if IE]><meta http-equiv='X-UA-Compatible' content='IE=edge,chrome=1'><![endif]-->

		<!-- WEB FONTS : use %7C instead of | (pipe) -->
		<link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,400,600%7CRaleway:300,400,500,600,700%7CLato:300,400,400italic,600,700"" rel=""stylesheet"" type=""text/css"" />

		<!-- CORE CSS -->
		<link href=""css/bootstrap.min.css"" rel=""stylesheet"" type=""text/css"" />

		<!-- THEME CSS -->
		<link href=""css/essentials.css"" rel=""stylesheet"" type=""text/css"" />
		<link href=""css/layout.css"" rel=""stylesheet"" type=""text/css"" />

		<!-- PAGE LEVEL SCRIPTS -->
		<link href=""css/header-1.css"" rel=""stylesheet"" type=""text/css"" />
		<link href=""css/color_scheme/green.css"" rel=""stylesheet"" type=""text/css"" id=""color_scheme"" />
	");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

	<!--
		AVAILABLE BODY CLASSES:
		
		smoothscroll 			= create a browser smooth scroll
		enable-animation		= enable WOW animations

		bg-grey					= grey background
		grain-grey				= grey grain background
		grain-blue				= blue grain background
		grain-green				= green grain background
		grain-blue				= blue grain background
		grain-orange			= orange grain background
		grain-yellow			= yellow grain background
		
		boxed 					= boxed layout
		pattern1 ... patern11	= pattern background
		menu-vertical-hide		= hidden, open on click
		
		BACKGROUND IMAGE [together with .boxed class]
		data-background=""assets/images/_smarty/boxed_background/1.jpg""
	-->
	");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58b4abd7c91580be7db728d95d287c0cd43160f910178", async() => {
                WriteLiteral(@"

		<!-- wrapper -->
		<div id=""wrapper"">


			<!-- 
				AVAILABLE HEADER CLASSES

				Default nav height: 96px
				.header-md 		= 70px nav height
				.header-sm 		= 60px nav height

				.b-0 		= remove bottom border (only with transparent use)
				.transparent	= transparent header
				.translucent	= translucent header
				.sticky			= sticky header
				.static			= static header
				.dark			= dark header
				.bottom			= header on bottom
				
				shadow-before-1 = shadow 1 header top
				shadow-after-1 	= shadow 1 header bottom
				shadow-before-2 = shadow 2 header top
				shadow-after-2 	= shadow 2 header bottom
				shadow-before-3 = shadow 3 header top
				shadow-after-3 	= shadow 3 header bottom

				.clearfix		= required for mobile menu, do not remove!

				Example Usage:  class=""clearfix sticky header-sm transparent b-0""
			-->
			<div id=""header"" class=""navbar-toggleable-md sticky clearfix"">

				<!-- TOP NAV -->
				<header id=""topNav"">
					<div class=""container"">

");
                WriteLiteral(@"						<!-- Mobile Menu Button -->
						<button class=""btn btn-mobile"" data-toggle=""collapse"" data-target="".nav-main-collapse"">
							<i class=""fa fa-bars""></i>
						</button>

						<!-- BUTTONS -->
						<ul class=""float-right nav nav-pills nav-second-main"">



						</ul>
						<!-- /BUTTONS -->


						<!-- Logo -->
						<a class=""logo float-left"" href=""index.html"">
							<img src=""images/R2.png""");
                BeginWriteAttribute("alt", " alt=\"", 3392, "\"", 3398, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
						</a>

						<!-- 
							Top Nav 
							
							AVAILABLE CLASSES:
							submenu-dark = dark sub menu
						-->
						<div class=""navbar-collapse collapse float-right nav-main-collapse"">
							<nav class=""nav-main"">

								<!--
									NOTE
									
									For a regular link, remove ""dropdown"" class from LI tag and ""dropdown-toggle"" class from the href.
									Direct Link Example: 

									<li>
										<a href=""#"">HOME</a>
									</li>
								-->
								<ul id=""topMain"" class=""nav nav-pills nav-main"">
									<li class=""dropdown active""><!-- HOME -->
										");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58b4abd7c91580be7db728d95d287c0cd43160f912733", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\tHome\r\n\t\t\t\t\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t<li class=\"dropdown\"><!-- PAGES -->\r\n\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58b4abd7c91580be7db728d95d287c0cd43160f914191", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\tProduct management\r\n\t\t\t\t\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
										
									</li>
									<li class=""dropdown mega-menu""><!-- PORTFOLIO -->
										<a class=""dropdown-toggle"" href=""#"">
											Intervention request
										</a>
									
									</li>
									<li class=""dropdown""><!-- BLOG and SHOP -->
										");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58b4abd7c91580be7db728d95d287c0cd43160f915843", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\tPrivacy\r\n\t\t\t\t\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
										
									</li>
									<li class=""dropdown mega-menu""><!-- SHORTCODES -->
										<a class=""dropdown-toggle"" href=""#"">
											SHORTCODES
										</a>
										
									</li>



									<!-- 
										MENU ANIMATIONS
											.nav-animate-fadeIn
											.nav-animate-fadeInUp
											.nav-animate-bounceIn
											.nav-animate-bounceInUp
											.nav-animate-flipInX
											.nav-animate-flipInY
											.nav-animate-zoomIn
											.nav-animate-slideInUp

											.nav-hover-animate 		= animate text on hover

											.hover-animate-bounceIn = bounceIn effect on mouse over of main menu
									-->
								
								</ul>

							</nav>
						</div>

					</div>
				</header>
				<!-- /Top Nav -->

			</div>



			<!-- 
				SLIDER 
				
				.h-300
				.h-350
				.h-400
				.h-450
				.h-500
				.h-550
				.h-600
				.h-650
				.h-700
				.h-750
				.h-800
			-->
			<section class=""h-500"" id=""slider"" style=""ba");
                WriteLiteral(@"ckground:url('images/khartoum-corporate-center.jpg')"">
				<div class=""overlay dark-6""><!-- dark overlay [0 to 9 opacity] --></div>
			
				<div class=""display-table"">
					<div class=""display-table-cell vertical-align-middle"">
						
						<div class=""container text-center"">
							
							<h1 class=""m-0 wow fadeInUp"" data-wow-delay=""0.4s"">
								Welcome to 
								<!--
									TEXT ROTATOR
									data-animation=""fade|flip|flipCube|flipUp|spin""
								-->
								<span class=""rotate "" data-animation=""fade"" data-speed=""1500"">
									Rocket Elevator
								</span>
							</h1>

							<p class=""lead font-lato fs-30 wow fadeInUp"" data-wow-delay=""0.7s"">
								Over <span class=""countTo theme-color fw-400 font-style-italic"" data-speed=""4000"">550</span> project done! 
							
							</p>

						</div>

					</div>
				</div>

			</section>
			<!-- /SLIDER -->



			<!-- -->
			<section>
				<div class=""container"">

					<!-- FEATURED BOXES 3 -->
					<div class=""ro");
                WriteLiteral(@"w"">
						<div class=""col-md-3 col-6 mb-30"">
							<div class=""text-center"">
								<i class=""ico-light ico-lg ico-rounded ico-hover et-circle-compass""></i>
								<h4>Design</h4>
								<p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus.</p>
							</div>
						</div>

						<div class=""col-md-3 col-6 mb-30"">
							<div class=""text-center"">
								<i class=""ico-light ico-lg ico-rounded ico-hover et-piechart""></i>
								<h4>Analytics</h4>
								<p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus.</p>
							</div>
						</div>

						<div class=""col-md-3 col-6 mb-30"">
							<div class=""text-center"">
								<i class=""ico-light ico-lg ico-rounded ico-hover et-strategy""></i>
								<h4>Development</h4>
								<p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus.</p>
							</div>
						</div>

						<div class=""col-md-3 col-6 mb-30"">
							<div class=""text-center"">
								<i class=""ico-light ico-lg ico-rounded ico-hover et-st");
                WriteLiteral(@"reetsign""></i>
								<h4>Marketing</h4>
								<p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus. </p>
							</div>
						</div>

						<div class=""col-md-3 col-6 mb-30"">
							<div class=""text-center"">
								<i class=""ico-light ico-lg ico-rounded ico-hover et-bargraph""></i>
								<h4>Statistics</h4>
								<p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus.</p>
							</div>
						</div>

						<div class=""col-md-3 col-6 mb-30"">
							<div class=""text-center"">
								<i class=""ico-light ico-lg ico-rounded ico-hover et-trophy""></i>
								<h4>Winners</h4>
								<p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus.</p>
							</div>
						</div>

						<div class=""col-md-3 col-6 mb-30"">
							<div class=""text-center"">
								<i class=""ico-light ico-lg ico-rounded ico-hover et-profile-female""></i>
								<h4>Clients</h4>
								<p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus.</p>
							</div>
						");
                WriteLiteral(@"</div>

						<div class=""col-md-3 col-6 mb-30"">
							<div class=""text-center"">
								<i class=""ico-light ico-lg ico-rounded ico-hover et-heart""></i>
								<h4>Favourite</h4>
								<p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus. </p>
							</div>
						</div>
					</div>
					<!-- /FEATURED BOXES 3 -->

				</div>
			</section>
			<!-- / -->



			<!-- CALLOUT -->
			<div class=""alert alternate bordered-bottom m-0"">
				<div class=""container"">

					<div class=""row"">

						<div class=""col-md-9 col-sm-12""><!-- left text -->
							<h3><strong>OVER <span class=""countTo fw-400"" data-speed=""3000"">8300</span> CLIENTS TRUST OUR SERVICES</strong></h3>
							<p class=""font-lato fw-300 fs-20 mb-0"">
								We truly care about our users and our product.
							</p>
						</div><!-- /left text -->

						
						<div class=""col-md-3 col-sm-12 text-right""><!-- right btn -->
							<a href=""page-services-1.html"" class=""btn btn-3d btn-teal btn-lg fs-16"">OUR SER");
                WriteLiteral(@"VICES</a>
						</div><!-- /right btn -->

					</div>

				</div>
			</div>
			<!-- /CALLOUT -->




			<!-- -->
			<section>
				<div class=""container"">

					<!-- -->
					<article class=""row"">
						<div class=""col-md-6"">
							<!-- OWL SLIDER -->
							<div class=""owl-carousel buttons-autohide controlls-over m-0"" data-plugin-options='{""items"": 1, ""autoHeight"": true, ""navigation"": true, ""pagination"": true, ""transitionStyle"":""backSlide"", ""progressBar"":""true""}'>
								<div>
									<img class=""img-fluid"" src=""images/AdobeStock_3294993.jpeg""");
                BeginWriteAttribute("alt", " alt=\"", 10326, "\"", 10332, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"height:40vh;width:100%\">\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t<img class=\"img-fluid\" src=\"images/new_futuric.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 10458, "\"", 10464, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"height:40vh;width:100%\">\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t<img class=\"img-fluid\" src=\"images/adriano-design-house-on-the-paddy-rice-china-designboom-05.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 10637, "\"", 10643, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"height:40vh;width:100%\">\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t<img class=\"img-fluid\" src=\"images/NewJerseyAvenue.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 10773, "\"", 10779, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""height:40vh;width:100%"">
								</div>
							</div>
							<!-- /OWL SLIDER -->
						</div>
						<div class=""col-md-6"">
							<h3>Areas of Expertise</h3>
							<p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam.</p>
							
							<p>Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem.</p>
							
							<p>Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit.</p>
							
							<p>Enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.</p>
						</div>
					</article>
					<!-- / -->

				</div>
			</section>
			<!-- / -->




			<!-- CALLOUT -->
			<section class=""callout-dark heading-title heading-arrow-bottom"">
				<div class=""container"">

					<div class=""text-center"">
						<h");
                WriteLiteral(@"3 class=""fs-30"">Rocket Elevator since 1997</h3>
						<p>We can't solve problems by using the same kind of thinking we used when we created them.</p>
					</div>

				</div>
			</section>
			<!-- /CALLOUT -->




			<!--
				.box-pink
				.box-blue
				.box-orange
				.box-yellow
				.box-purple
				.box-red
				.box-brown
				.box-green
				.box-black
				.box-gray
				.box-teal
			-->
			<div class=""row box-gradient box-teal"">
				<div class=""col-6 col-sm-3"">
					<i class=""fa fa-child fa-4x""></i>
					<h2 class=""countTo font-raleway"" data-speed=""3000"">8165</h2>
					<p>HAPPY CUSTOMERS</p>
				</div>

				<div class=""col-6 col-sm-3"">
					<i class=""fa fa-smile-o fa-4x""></i>
					<h2 class=""countTo font-raleway"" data-speed=""3000"">1033</h2>
					<p>COMPLETED PROJECTS</p>
				</div>

				<div class=""col-6 col-sm-3"">
					<i class=""fa fa-heart fa-4x""></i>
					<h2 class=""countTo font-raleway"" data-speed=""3000"">24567</h2>
					<p>MASSAGES</p>
				</div>

				<div class=");
                WriteLiteral(@"""col-6 col-sm-3"">
					<i class=""fa fa-female fa-4x""></i>
					<h2 class=""countTo font-raleway"" data-speed=""3000"">68</h2>
					<p>MOTHERS TO BE</p>
				</div>
			</div>





			<!-- -->
			<section>
				<div class=""container"">

					<div class=""row"">

						<!-- toggle -->
						<div class=""col-md-4 col-sm-4"">
							<div class=""toggle toggle-accordion toggle-transparent toggle-bordered-full"">

								<div class=""toggle active"">
									<label>Lorem ipsum dolor.</label>
									<div class=""toggle-content"">
										<p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.</p>
									</div>
								</div>

								<div class=""toggle"">
									<label>Sit amet, consectetur.</label>
									<div class=""toggle-content"">
										<p>Maecenas metus nulla, commodo a sodales sed, dignissim pretium nunc.</p>
									</d");
                WriteLiteral(@"iv>
								</div>

								<div class=""toggle"">
									<label>Consectetur adipiscing elit.</label>
									<div class=""toggle-content"">
										<p>Ut enim massa, sodales tempor convallis et, iaculis ac massa.</p>
									</div>
								</div>

							</div>
						</div>
						<!-- /toggle -->

						<!-- skills -->
						<div class=""col-md-4 col-sm-4"">
							<h4>Our Skills</h4>

							<label>
								<span class=""float-right"">60%</span>
								MARKETING
							</label>
							<div class=""progress progress-xxs"">
								<div class=""progress-bar progress-bar-warning"" role=""progressbar"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 60%; min-width: 2em;""></div>
							</div>

							<label>
								<span class=""float-right"">88%</span>
								SALES
							</label>
							<div class=""progress progress-xxs"">
								<div class=""progress-bar progress-bar-danger"" role=""progressbar"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: ");
                WriteLiteral(@"88%; min-width: 2em;""></div>
							</div>

							<label>
								<span class=""float-right"">93%</span>
								DESIGN
							</label>
							<div class=""progress progress-xxs"">
								<div class=""progress-bar progress-bar-success"" role=""progressbar"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 93%; min-width: 2em;""></div>
							</div>

							<label>
								<span class=""float-right"">77%</span>
								DEVELOPMENT
							</label>
							<div class=""progress progress-xxs"">
								<div class=""progress-bar progress-bar-info"" role=""progressbar"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 77%; min-width: 2em;""></div>
							</div>

							<label>
								<span class=""float-right"">99%</span>
								OTHER
							</label>
							<div class=""progress progress-xxs"">
								<div class=""progress-bar progress-bar-primary"" role=""progressbar"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 99%; min-width: 2em;""></div>
");
                WriteLiteral(@"							</div>

						</div>
						<!-- /skills -->

						<!-- recent news -->
						<div class=""col-md-4 col-sm-4"">
							<h4>Recent News</h4>

							<div class=""row tab-post""><!-- post -->
								<div class=""col-md-2 col-sm-2 col-2"">
									<a href=""blog-sidebar-left.html"">
										<img src=""images/people/1-min.jpg"" width=""50""");
                BeginWriteAttribute("alt", " alt=\"", 16249, "\"", 16255, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
									</a>
								</div>
								<div class=""col-md-10 col-sm-10 col-10"">
									<a href=""blog-sidebar-left.html"" class=""tab-post-link"">Maecenas metus nulla</a>
									<small>June 29 2014</small>
								</div>
							</div><!-- /post -->

							<div class=""row tab-post""><!-- post -->
								<div class=""col-md-2 col-sm-2 col-2"">
									<a href=""blog-sidebar-left.html"">
										<img src=""images/people/2-min.jpg"" width=""50""");
                BeginWriteAttribute("alt", " alt=\"", 16711, "\"", 16717, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
									</a>
								</div>
								<div class=""col-md-10 col-sm-10 col-10"">
									<a href=""blog-sidebar-left.html"" class=""tab-post-link"">Curabitur pellentesque neque eget</a>
									<small>June 29 2014</small>
								</div>
							</div><!-- /post -->

							<div class=""row tab-post""><!-- post -->
								<div class=""col-md-2 col-sm-2 col-2"">
									<a href=""blog-sidebar-left.html"">
										<img src=""images/people/3-min.jpg"" width=""50""");
                BeginWriteAttribute("alt", " alt=\"", 17186, "\"", 17192, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
									</a>
								</div>
								<div class=""col-md-10 col-sm-10 col-10"">
									<a href=""blog-sidebar-left.html"" class=""tab-post-link"">Nam et lacus neque. Ut enim massa</a>
									<small>June 29 2014</small>
								</div>
							</div><!-- /post -->

						</div>
						<!-- /recent news -->

					</div>

				</div>
			</section>
			<!-- / -->

			<!-- FOOTER -->
			<footer id=""footer"">
				<div class=""container"">

					<div class=""row"">
						
						<div class=""col-md-3"">
							<!-- Footer Logo -->
							<img class=""footer-logo"" src=""images/R2.png""");
                BeginWriteAttribute("alt", " alt=\"", 17789, "\"", 17795, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""width:60%""/>

							<!-- Small Description -->
							<p>Integer posuere erat a ante venenatis dapibus posuere velit aliquet.</p>

							<!-- Contact Address -->
							<address>
								<ul class=""list-unstyled"">
									<li class=""footer-sprite address"">
										PO Box 21132<br>
										Here Weare St, Melbourne<br>
										Vivas 2355 Australia<br>
									</li>
									<li class=""footer-sprite phone"">
										Phone: 1-800-565-2390
									</li>
									<li class=""footer-sprite email"">
										<a href=""mailto:support@yourname.com"">support@yourname.com</a>
									</li>
								</ul>
							</address>
							<!-- /Contact Address -->

						</div>

						<div class=""col-md-3"">

							<!-- Latest Blog Post -->
							<h4 class=""letter-spacing-1"">LATEST NEWS</h4>
							<ul class=""footer-posts list-unstyled"">
								<li>
									<a href=""#"">Donec sed odio dui. Nulla vitae elit libero, a pharetra augue</a>
									<small>29 June 2017</small>
								");
                WriteLiteral(@"</li>
								<li>
									<a href=""#"">Nullam id dolor id nibh ultricies</a>
									<small>29 June 2017</small>
								</li>
								<li>
									<a href=""#"">Duis mollis, est non commodo luctus</a>
									<small>29 June 2017</small>
								</li>
							</ul>
							<!-- /Latest Blog Post -->

						</div>

						<div class=""col-md-2"">

							<!-- Links -->
							
							<!-- /Links -->

						</div>

						<div class=""col-md-4"">

							<!-- Newsletter Form -->
							<h4 class=""letter-spacing-1"">KEEP IN TOUCH</h4>
							<p>Subscribe to Our Newsletter to get Important News &amp; Offers</p>

							");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58b4abd7c91580be7db728d95d287c0cd43160f934083", async() => {
                    WriteLiteral(@"
								<div class=""input-group"">
									<span class=""input-group-addon""><i class=""fa fa-envelope""></i></span>
									<input type=""email"" id=""email"" name=""email"" class=""form-control required"" placeholder=""Enter your Email"">
									<span class=""input-group-btn"">
										<button class=""btn btn-success"" type=""submit"">Subscribe</button>
									</span>
								</div>
							");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
							<!-- /Newsletter Form -->

							<!-- Social Icons -->
							<div class=""mt-20"">
								<a href=""#"" class=""social-icon social-icon-border social-facebook float-left"" data-toggle=""tooltip"" data-placement=""top"" title=""Facebook"">

									<i class=""icon-facebook""></i>
									<i class=""icon-facebook""></i>
								</a>

								<a href=""#"" class=""social-icon social-icon-border social-twitter float-left"" data-toggle=""tooltip"" data-placement=""top"" title=""Twitter"">
									<i class=""icon-twitter""></i>
									<i class=""icon-twitter""></i>
								</a>

								<a href=""#"" class=""social-icon social-icon-border social-gplus float-left"" data-toggle=""tooltip"" data-placement=""top"" title=""Google plus"">
									<i class=""icon-gplus""></i>
									<i class=""icon-gplus""></i>
								</a>

								<a href=""#"" class=""social-icon social-icon-border social-linkedin float-left"" data-toggle=""tooltip"" data-placement=""top"" title=""Linkedin"">
									<i class=""icon-linkedin""></i>
									<i clas");
                WriteLiteral(@"s=""icon-linkedin""></i>
								</a>

								<a href=""#"" class=""social-icon social-icon-border social-rss float-left"" data-toggle=""tooltip"" data-placement=""top"" title=""Rss"">
									<i class=""icon-rss""></i>
									<i class=""icon-rss""></i>
								</a>
					
							</div>
							<!-- /Social Icons -->

						</div>

					</div>

				</div>

				<div class=""copyright"">
					<div class=""container"">
						<ul class=""float-right m-0 list-inline mobile-block"">
							<li><a href=""#"">Terms &amp; Conditions</a></li>
							<li>&bull;</li>
							<li><a href=""#"">Privacy</a></li>
						</ul>
						&copy; All Rights Reserved, Company LTD
					</div>
				</div>
			</footer>
			<!-- /FOOTER -->

		</div>
		<!-- /wrapper -->


		<!-- SCROLL TO TOP -->
		<a href=""#"" id=""toTop""></a>


		<!-- PRELOADER -->
");
                WriteLiteral("\r\n\r\n\t\t<!-- JAVASCRIPT FILES -->\r\n\t\t<script>var plugin_path = \'../lib/\';</script>\r\n\t\t<script src=\"lib/jquery/dist/jquery-3.3.1.min.js\"></script>\r\n\r\n\t\t<script src=\"js/scripts.js\"></script>\r\n\t\t\r\n\t\t<!-- STYLESWITCHER - REMOVE -->\r\n");
                WriteLiteral("\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer_Portal.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Customer_Portal.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Customer_Portal.Pages.IndexModel>)PageContext?.ViewData;
        public Customer_Portal.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
