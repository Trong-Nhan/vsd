#pragma checksum "C:\Users\Admin\Desktop\export-html-tables-to-excel-worksheet-in-c-sharp-master\Export-HTML-table-from-web-page-to-Excel\Views\ImportHtmlTable\ImportHtmlTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "321e68f35664ec7563c63adc585c65a31ac23f50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ImportHtmlTable_ImportHtmlTable), @"mvc.1.0.view", @"/Views/ImportHtmlTable/ImportHtmlTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ImportHtmlTable/ImportHtmlTable.cshtml", typeof(AspNetCore.Views_ImportHtmlTable_ImportHtmlTable))]
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
#line 1 "C:\Users\Admin\Desktop\export-html-tables-to-excel-worksheet-in-c-sharp-master\Export-HTML-table-from-web-page-to-Excel\Views\_ViewImports.cshtml"
using ImportHtmlTable;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\export-html-tables-to-excel-worksheet-in-c-sharp-master\Export-HTML-table-from-web-page-to-Excel\Views\_ViewImports.cshtml"
using ImportHtmlTable.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"321e68f35664ec7563c63adc585c65a31ac23f50", @"/Views/ImportHtmlTable/ImportHtmlTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a74faf55486f7b1210b69cb0fafd6fe9ee69659f", @"/Views/_ViewImports.cshtml")]
    public class Views_ImportHtmlTable_ImportHtmlTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Admin\Desktop\export-html-tables-to-excel-worksheet-in-c-sharp-master\Export-HTML-table-from-web-page-to-Excel\Views\ImportHtmlTable\ImportHtmlTable.cshtml"
  Html.BeginForm("ImportHtmlTable", "ImportHtmlTable", FormMethod.Post);
    {

#line default
#line hidden
            BeginContext(79, 9107, true);
            WriteLiteral(@"        <div class=""Common"">
            <div class=""tablediv"">
                <div class=""rowdiv"">
                    <p>
                        Essential XlsIO supports exporting HTML tables into Excel worksheets. 
                        The <b>ImportHtmlTable</b> method loads an HTML file and exports all
                         the tables in the file to the worksheet.
                    </p>
                    <b>Features:</b>
                    <br />
                    <ul>
                        <li>Imports HTML table</li>
                        <li>Imports with table formatting </li>
                    </ul>
                    <br />
                    <div id=""cssStyle"">
                        <style type=""text/css"">
                            th {
                                color:rgb(0,0,0);
                                font-family:Tahoma, sans-serif;
                                font-size:10pt;
                                white-space:nowrap;
                           ");
            WriteLiteral(@"     background-color:rgb(255,174,33);
                                border-top:solid;
                                border-top-width: thin;
                                border-bottom:solid;
                                border-bottom-width:thin;
                                border-left:solid;
                                border-left-width:thin;
                                border-right:solid;
                                border-right-width:thin;
                                border-top-color:rgb(0,0,0);
                                border-bottom-color:rgb(0,0,0);
                                border-left-color:rgb(0,0,0);
                                border-right-color:rgb(0,0,0);
                                font-weight:bold;
                                vertical-align:bottom;
                            }

                            td {
                                color:rgb(0,0,0);
                                font-family:Tahoma, sans-serif;
                   ");
            WriteLiteral(@"             font-size:10pt;
                                white-space:nowrap;
                                background-color:rgb(239,243,247);
                                border-left:solid;
                                border-left-width:thin;
                                border-right:solid;
                                border-right-width:thin;
                                border-top-color:rgb(0,0,0);
                                border-bottom-color:rgb(0,0,0);
                                border-bottom:solid;
                                border-bottom-width:thin;
                                border-left-color:rgb(0,0,0);
                                border-right-color:rgb(0,0,0);
                                vertical-align:bottom;
                            }
                        </style>
                    </div>
                    <div id=""Grid"">
                        <table cellspacing=""0"" width=""500"" 
                        style=""table-layout:fixed;border-c");
            WriteLiteral(@"ollapse:collapse;width:500pt"">
                            <tr>
                                <th class=""X64"" style=""text-align:left;"">
                                    <span>CustomerID</span>
                                </th>
                                <th class=""X64"" style=""text-align:left;"">
                                    <span>CompanyName</span>
                                </th>
                                <th class=""X64"" style=""text-align:left;"">
                                    <span>ContactName</span>
                                </th>
                                <th class=""X64"" style=""text-align:left;"">
                                    <span>Phone</span>
                                </th>
                            </tr>
                            <tr height=""25"">
                                <td class=""X65"" style=""text-align:left;"">
                                    <span>ALFKI</span>
                                </td>
                             ");
            WriteLiteral(@"   <td class=""X65"" style=""text-align:left;"">
                                    <span>Alfreds Futterkiste</span>
                                </td>
                                <td class=""X65"" style=""text-align:left;"">
                                    <span>Maria Anders</span>
                                </td>

                                <td class=""X65"" style=""text-align:left;"">
                                    <span>030-0074321</span>
                                </td>
                            </tr>
                            <tr height=""25"">
                                <td class=""X65"" style=""text-align:left;"">
                                    <span>ANATR</span>
                                </td>
                                <td class=""X65"" style=""text-align:left;"">
                                    <span>Ana Trujillo Emparedados</span>
                                </td>
                                <td class=""X65"" style=""text-align:left;"">
                  ");
            WriteLiteral(@"                  <span>Ana Trujillo</span>
                                </td>
                                <td class=""X65"" style=""text-align:left;"">
                                    <span>(5) 555-4729</span>
                                </td>
                            </tr>
                            <tr height=""25"">
                                <td class=""X65"" style=""text-align:left;"">
                                    <span>ANTON</span>
                                </td>
                                <td class=""X65"" style=""text-align:left;"">
                                    <span>Antonio Moreno Taquería</span>
                                </td>
                                <td class=""X65"" style=""text-align:left;"">
                                    <span>Antonio Moreno</span>
                                </td>
                                <td class=""X65"" style=""text-align:left;"">
                                    <span>(5) 555-3932</span>
                         ");
            WriteLiteral(@"       </td>
                            </tr>
                            <tr height=""25"">
                                <td class=""X65"" style=""text-align:left;"">
                                    <span>AROUT</span>
                                </td>
                                <td class=""X65"" style=""text-align:left;"">
                                    <span>Around the Horn</span>
                                </td>
                                <td class=""X65"" style=""text-align:left;"">
                                    <span>Thomas Hardy</span>
                                </td>
                                <td class=""X65"" style=""text-align:left;"">
                                    <span>(171) 555-7788</span>
                                </td>
                            </tr>
                            <tr height=""25"">
                                <td class=""X65"" style=""text-align:left;"">
                                    <span>BERGS</span>
                              ");
            WriteLiteral(@"  </td>
                                <td class=""X65"" style=""text-align:left;"">
                                    <span>Berglunds snabbköp</span>
                                </td>
                                <td class=""X65"" style=""text-align:left;"">
                                    <span>Christina Berglund</span>
                                </td>
                                <td class=""X65"" style=""text-align:left;"">
                                    <span>0921-12 34 65</span>
                                </td>
                            </tr>
                            <tr height=""25"">
                                <td class=""X65"" style=""text-align:left;"">
                                    <span>BLAUS</span>
                                </td>
                                <td class=""X65"" style=""text-align:left;"">
                                    <span>Blauer See Delikatessen</span>
                                </td>
                                <td class=""X65"" st");
            WriteLiteral(@"yle=""text-align:left;"">
                                    <span>Hanna Moos</span>
                                </td>
                                <td class=""X65"" style=""text-align:left;"">
                                    <span>0621-08460</span>
                                </td>
                            </tr>

                        </table>
                    </div>
                    </div>
                    <br />
                    <input name=""tableHTML"" id=""tbl"" hidden=""hidden""/>
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <input id=""ImportTbl"" class=""buttonStyle"" type=""submit"" 
                            name=""button"" value=""Export"" onclick=""importHTML()"" 
                            style=""width:125px;"" />
                        </div>
                    </div>
                </div>
        </div>
");
            EndContext();
#line 179 "C:\Users\Admin\Desktop\export-html-tables-to-excel-worksheet-in-c-sharp-master\Export-HTML-table-from-web-page-to-Excel\Views\ImportHtmlTable\ImportHtmlTable.cshtml"
        Html.EndForm();
    } 

#line default
#line hidden
            BeginContext(9218, 496, true);
            WriteLiteral(@"        <script type=""text/javascript"">
                function importHTML() {
                    let value = ""<html>"" + document.getElementById(""cssStyle"").innerHTML 
                    + ""<body>"" + document.getElementById(""Grid"").innerHTML + ""</body></html>"";
                    value = value.replace(""<tbody>"", """");
                    value = value.replace(""</tbody>"", """");
                    document.getElementById(""tbl"").setAttribute(""value"", value);
            }
        </script>

");
            EndContext();
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
