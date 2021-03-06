﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Easy.Constant;
    using Easy.Extend;
    using Easy.Web.CMS;
    using Easy.Web.Extend;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Modules/Common/Views/Shared/_DesignLayout.cshtml")]
    public partial class _Modules_Common_Views_Shared__DesignLayout_cshtml : Easy.Web.Page.ViewPage<Easy.Web.CMS.Layout.LayoutEntity>
    {
        public _Modules_Common_Views_Shared__DesignLayout_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
  
    Script.Reqiured("jQueryUi").AtFoot();
    Style.Reqiured("Layout").AtHead();
    Style.Reqiured("bootStrap").AtHead();
    Script.Reqiured("admin").AtFoot();
    Model.ContainerClass = Model.ContainerClass ?? "container";

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("<!DOCTYPE html>\r\n<!--[if lt IE 7 ]><html");

WriteLiteral(" class=\"ie ie6\"");

WriteLiteral(" lang=\"zh\"");

WriteLiteral("> <![endif]-->\r\n<!--[if IE 7 ]><html");

WriteLiteral(" class=\"ie ie7\"");

WriteLiteral(" lang=\"zh\"");

WriteLiteral("> <![endif]-->\r\n<!--[if IE 8 ]><html");

WriteLiteral(" class=\"ie ie8\"");

WriteLiteral(" lang=\"zh\"");

WriteLiteral("> <![endif]-->\r\n<!--[if (gte IE 9)|!(IE)]><!-->\r\n<html");

WriteLiteral(" class=\"not-ie\"");

WriteLiteral(" lang=\"zh\"");

WriteLiteral(">\r\n<!--<![endif]-->\r\n<head>\r\n    <meta");

WriteLiteral(" http-equiv=\"Content-Type\"");

WriteLiteral(" content=\"text/html; charset=utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge,chrome=1\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" http-equiv=\"cache-control\"");

WriteLiteral(" content=\"no-cache\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" http-equiv=\"cache-control\"");

WriteLiteral(" content=\"no-store\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" http-equiv=\"expires\"");

WriteLiteral(" content=\"0\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" http-equiv=\"pragma\"");

WriteLiteral(" content=\"no-cache\"");

WriteLiteral(" />\r\n\r\n    <title>[设计]");

            
            #line 25 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
          Write(Model.LayoutName);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n");

WriteLiteral("    ");

            
            #line 26 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
Write(StyleAtHead());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 27 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
Write(ScriptAtHead());

            
            #line default
            #line hidden
WriteLiteral("\r\n</head>\r\n<body");

WriteLiteral(" class=\"front\"");

WriteLiteral(">\r\n");

            
            #line 30 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 30 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
     using (Html.BeginForm("SaveLayout", "Layout", new { module = "admin" }, FormMethod.Post, new { id = "LayoutInfo" }))
    {

            
            #line default
            #line hidden
WriteLiteral("        <nav");

WriteLiteral(" id=\"toolBar\"");

WriteLiteral(" class=\"navbar navbar-inverse navbar-fixed-top\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"navbar-header\"");

WriteLiteral(">\r\n                        <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"navbar-toggle collapsed\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-target=\"#bs-example-navbar-collapse-1\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">Toggle navigation</span>\r\n                            <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n                            <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n                            <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n                        </button>\r\n                        <a");

WriteLiteral(" class=\"navbar-brand\"");

WriteLiteral("><span");

WriteLiteral(" class=\"badge\"");

WriteLiteral(">布局设计</span></a>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"collapse navbar-collapse\"");

WriteLiteral(" id=\"bs-example-navbar-collapse-1\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"navbar-form navbar-left\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" class=\"AddContainer btn btn-default\"");

WriteLiteral(" data-container=\"container-fluid\"");

WriteLiteral(">\r\n                                <span");

WriteLiteral(" class=\"badge\"");

WriteLiteral(">1</span>\r\n                                <i");

WriteLiteral(" class=\"glyphicon glyphicon-unchecked\"");

WriteLiteral("></i>\r\n                                容器\r\n                            </label>\r\n" +
"                            <label");

WriteLiteral(" class=\"AddRow btn btn-primary\"");

WriteLiteral(" data-container=\"container-fluid\"");

WriteLiteral(">\r\n                                <span");

WriteLiteral(" class=\"badge\"");

WriteLiteral(">2</span>\r\n                                <i");

WriteLiteral(" class=\"glyphicon glyphicon-align-justify\"");

WriteLiteral("></i>\r\n                                行\r\n                            </label>\r\n " +
"                           <div");

WriteLiteral(" class=\"btn-group\"");

WriteLiteral(">\r\n                                <label");

WriteLiteral(" id=\"add-col-handle\"");

WriteLiteral(" class=\"AddCol btn btn-success\"");

WriteLiteral(" data-col=\"col-md-\"");

WriteLiteral(" data-val=\"6\"");

WriteLiteral(">\r\n                                    <span");

WriteLiteral(" class=\"badge\"");

WriteLiteral(">3</span>\r\n                                    <i");

WriteLiteral(" class=\"glyphicon glyphicon-tasks\"");

WriteLiteral("></i>\r\n                                    列 <span");

WriteLiteral(" class=\"col-size-info\"");

WriteLiteral(">宽 6/12</span>\r\n                                </label>\r\n                       " +
"         <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-success dropdown-toggle\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" aria-haspopup=\"true\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(">\r\n                                    <span");

WriteLiteral(" class=\"caret\"");

WriteLiteral("></span>\r\n                                    <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">Toggle Dropdown</span>\r\n                                </button>\r\n             " +
"                   <ul");

WriteLiteral(" class=\"dropdown-menu col-size\"");

WriteLiteral(">\r\n                                    <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-val=\"1\"");

WriteLiteral(">宽 1/12</a></li>\r\n                                    <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-val=\"2\"");

WriteLiteral(">宽 2/12</a></li>\r\n                                    <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-val=\"3\"");

WriteLiteral(">宽 3/12</a></li>\r\n                                    <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-val=\"4\"");

WriteLiteral(">宽 4/12</a></li>\r\n                                    <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-val=\"5\"");

WriteLiteral(">宽 5/12</a></li>\r\n                                    <li");

WriteLiteral(" class=\"active\"");

WriteLiteral("><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-val=\"6\"");

WriteLiteral(">宽 6/12</a></li>\r\n                                    <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-val=\"7\"");

WriteLiteral(">宽 7/12</a></li>\r\n                                    <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-val=\"8\"");

WriteLiteral(">宽 8/12</a></li>\r\n                                    <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-val=\"9\"");

WriteLiteral(">宽 9/12</a></li>\r\n                                    <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-val=\"10\"");

WriteLiteral(">宽 10/12</a></li>\r\n                                    <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-val=\"11\"");

WriteLiteral(">宽 11/12</a></li>\r\n                                    <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-val=\"12\"");

WriteLiteral(">宽 12/12</a></li>\r\n                                </ul>\r\n                       " +
"     </div>\r\n                            <span");

WriteLiteral(" class=\"badge\"");

WriteLiteral(" data-toggle=\"modal\"");

WriteLiteral(" data-target=\"#question\"");

WriteLiteral(" style=\"cursor:help\"");

WriteLiteral(">?</span>\r\n\r\n\r\n\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"navbar-form navbar-right\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"btn-group\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" class=\"btn btn-primary cancel\"");

WriteLiteral(">\r\n                                    <i");

WriteLiteral(" class=\"glyphicon glyphicon-arrow-left\"");

WriteLiteral("></i>\r\n                                    取消\r\n                                </" +
"a>\r\n");

            
            #line 92 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 92 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
                                 if (Model.Page != null)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <a");

WriteLiteral(" class=\"btn btn-primary\"");

WriteAttribute("href", Tuple.Create(" href=\"", 5615), Tuple.Create("\"", 5692)
            
            #line 94 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
, Tuple.Create(Tuple.Create("", 5622), Tuple.Create<System.Object, System.Int32>(Url.Action("Design", "Page", new { module = "admin", Model.Page.ID })
            
            #line default
            #line hidden
, 5622), false)
);

WriteLiteral(">\r\n                                        <i");

WriteLiteral(" class=\"glyphicon glyphicon-wrench\"");

WriteLiteral("></i>\r\n                                        页面设计\r\n                            " +
"        </a>\r\n");

            
            #line 98 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5937), Tuple.Create("\"", 6028)
            
            #line 99 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
, Tuple.Create(Tuple.Create("", 5944), Tuple.Create<System.Object, System.Int32>(Url.Action("LayoutWidget", "Layout", new { LayoutID = Model.ID, module = "admin" })
            
            #line default
            #line hidden
, 5944), false)
);

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">\r\n                                    <i");

WriteLiteral(" class=\"glyphicon glyphicon-compressed\"");

WriteLiteral("></i>\r\n                                    组件\r\n                                </" +
"a>\r\n                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 6252), Tuple.Create("\"", 6323)
            
            #line 103 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
, Tuple.Create(Tuple.Create("", 6259), Tuple.Create<System.Object, System.Int32>(Url.Action("Edit", "Layout", new {Model.ID, module = "admin" })
            
            #line default
            #line hidden
, 6259), false)
);

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">\r\n                                    <i");

WriteLiteral(" class=\"glyphicon glyphicon-edit\"");

WriteLiteral("></i>\r\n                                    属性\r\n                                </" +
"a>\r\n                                <a");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" id=\"save\"");

WriteLiteral(">\r\n                                    <i");

WriteLiteral(" class=\"glyphicon glyphicon-floppy-disk\"");

WriteLiteral("></i>\r\n                                    保存\r\n                                </" +
"a>\r\n");

WriteLiteral("                                ");

            
            #line 111 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
                           Write(Html.Partial("Partial.Menu", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"ContainerClass\"");

WriteLiteral(" name=\"ContainerClass\"");

WriteAttribute("value", Tuple.Create(" value=\"", 6937), Tuple.Create("\"", 6968)
            
            #line 113 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
                   , Tuple.Create(Tuple.Create("", 6945), Tuple.Create<System.Object, System.Int32>(Model.ContainerClass
            
            #line default
            #line hidden
, 6945), false)
);

WriteLiteral(" />\r\n                            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"LayoutId\"");

WriteLiteral(" name=\"ID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 7046), Tuple.Create("\"", 7063)
            
            #line 114 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
, Tuple.Create(Tuple.Create("", 7054), Tuple.Create<System.Object, System.Int32>(Model.ID
            
            #line default
            #line hidden
, 7054), false)
);

WriteLiteral(" />\r\n");

            
            #line 115 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 115 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
                             if (Model.Page != null)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"Page.ID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 7221), Tuple.Create("\"", 7243)
            
            #line 117 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
, Tuple.Create(Tuple.Create("", 7229), Tuple.Create<System.Object, System.Int32>(Model.Page.ID
            
            #line default
            #line hidden
, 7229), false)
);

WriteLiteral(" />\r\n");

            
            #line 118 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </div>\r\n                    </div>\r\n                </div" +
">\r\n            </div>\r\n        </nav>\r\n");

            
            #line 124 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" id=\"containers\"");

WriteLiteral(" class=\"hide\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 126 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
   Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n");

WriteLiteral("    ");

            
            #line 129 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
Write(Html.Partial("Layout/Templates"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 130 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 130 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
     if (!Model.Style.IsNullOrEmpty())
    {

            
            #line default
            #line hidden
WriteLiteral("        <link");

WriteAttribute("href", Tuple.Create(" href=\"", 7583), Tuple.Create("\"", 7615)
            
            #line 132 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
, Tuple.Create(Tuple.Create("", 7590), Tuple.Create<System.Object, System.Int32>(Url.Content(Model.Style)
            
            #line default
            #line hidden
, 7590), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n");

            
            #line 133 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"

    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"modal fade\"");

WriteLiteral(" id=\"question\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-labelledby=\"myModalLabel\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"modal-dialog\"");

WriteLiteral(" role=\"document\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" aria-label=\"Close\"");

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&times;</span></button>\r\n                    <h4");

WriteLiteral(" class=\"modal-title\"");

WriteLiteral(" id=\"myModalLabel\"");

WriteLiteral(">布局设计说明</h4>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n                    <h3>\r\n                        居中 / 拉伸\r\n                   " +
" </h3>\r\n                    <ol>\r\n                        <li>\r\n                " +
"            居中，宽度响应变化\r\n                            <div");

WriteLiteral(" class=\"table-responsive\"");

WriteLiteral(">\r\n                                <table");

WriteLiteral(" class=\"table table-bordered table-striped\"");

WriteLiteral(">\r\n                                    <thead>\r\n                                 " +
"       <tr>\r\n                                            <th>\r\n                 " +
"                               超小屏幕\r\n                                           " +
"     <small>手机 (&lt;768px)</small>\r\n                                            " +
"</th>\r\n                                            <th>\r\n                       " +
"                         小屏幕\r\n                                                <s" +
"mall>平板 (≥768px)</small>\r\n                                            </th>\r\n   " +
"                                         <th>\r\n                                 " +
"               中等屏幕\r\n                                                <small>桌面显示" +
"器 (≥992px)</small>\r\n                                            </th>\r\n         " +
"                                   <th>\r\n                                       " +
"         大屏幕\r\n                                                <small>大桌面显示器 (≥12" +
"00px)</small>\r\n                                            </th>\r\n              " +
"                          </tr>\r\n                                    </thead>\r\n " +
"                                   <tbody>\r\n                                    " +
"    <tr>\r\n                                            <td>100%</td>\r\n           " +
"                                 <td>750px</td>\r\n                               " +
"             <td>970px</td>\r\n                                            <td>117" +
"0px</td>\r\n                                        </tr>\r\n                       " +
"             </tbody>\r\n                                </table>\r\n               " +
"             </div>\r\n                        </li>\r\n                        <li>" +
"\r\n                            拉伸，宽度100%。<code>在这种情况下，选中行可以设置“行”居中或拉伸。</code>\r\n  " +
"                      </li>\r\n                    </ol>\r\n                    <h3>" +
"\r\n                        行 / 列宽 / 组件区域\r\n                    </h3>\r\n            " +
"        <ol>\r\n                        <li>\r\n                            <p><code" +
">拖放操作步骤：</code>1.容器，2.行 -> 容器，3.列 -> 行</p>\r\n                        </li>\r\n     " +
"                   <li>\r\n                            <p>行，直接加入到主容器中。</p>\r\n      " +
"                  </li>\r\n                        <li>\r\n                         " +
"   <p>列，只能加入到“行”中。列宽分成12等分，选择任意宽度划分行。</p>\r\n                        </li>\r\n      " +
"              </ol>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(">关闭</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </d" +
"iv>\r\n");

            
            #line 207 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 207 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
     if (!Model.Script.IsNullOrEmpty())
    {

            
            #line default
            #line hidden
WriteLiteral("        <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 11164), Tuple.Create("\"", 11196)
            
            #line 209 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
, Tuple.Create(Tuple.Create("", 11170), Tuple.Create<System.Object, System.Int32>(Url.Content(Model.Script)
            
            #line default
            #line hidden
, 11170), false)
);

WriteLiteral("></script>\r\n");

            
            #line 210 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 211 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
Write(StyleAtFoot());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 212 "..\..\Modules\Common\Views\Shared\_DesignLayout.cshtml"
Write(ScriptAtFoot());

            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
