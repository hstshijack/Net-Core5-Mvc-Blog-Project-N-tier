#pragma checksum "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3939670e0cdd93659fb8bc70da089fa2283af857"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
using ProgrammersBLog.Shared.Utilities.Results.ComplexTypes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3939670e0cdd93659fb8bc70da089fa2283af857", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ed1d286704faafb66f6c362a6279f19f91eff5f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProgrammersBLog.Entities.Dtos.CategoryListDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Kategoriler Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
 if (Model.ResultStatus == ResultStatus.Success)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div id=""modalPlaceHolder"" aria-hidden=""true"">
    </div>
    <div class=""card mb-4 mt-2"">
        <div class=""card-header"">
            Kategoriler
        </div>
        <div class=""card-body"">
            <div class=""spinner-border"" role=""status"" style=""display:none"">
                <span class=""sr-only-only""></span>
            </div>
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""categoriesTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Ad??</th>
                            <th>A????klamas??</th>
                            <th>Aktif Mi ?</th>
                            <th>Silinmi?? Mi ?</th>
                            <th>Not</th>
                            <th>Olu??turulma Tarihi</th>
                            <th>Olu??turan Kullan??c?? Ad?? </th>
                            <th>Son D??zenlenme Tarihi</th>
      ");
            WriteLiteral(@"                      <th>Son D??zenleyen Kullanc?? Ad??</th>
                            <th>????lemler</th>
                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>ID</th>
                            <th>Ad??</th>
                            <th>A????klamas??</th>
                            <th>Aktif Mi ?</th>
                            <th>Silinmi?? Mi ?</th>
                            <th>Not</th>
                            <th>Olu??turulma Tarihi</th>
                            <th>Olu??turan Kullan??c?? Ad?? </th>
                            <th>Son D??zenlenme Tarihi</th>
                            <th>Son D??zenleyen Kullanc?? Ad??</th>
                            <th>????lemler</th>
                        </tr>
                    </tfoot>
                    <tbody>
");
#nullable restore
#line 52 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                         foreach (var category in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("name", " name=\"", 2279, "\"", 2298, 1);
#nullable restore
#line 54 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 2286, category.Id, 2286, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <td>");
#nullable restore
#line 55 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 56 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 57 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 58 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 59 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.IsDeleted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 60 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 61 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 62 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.CreatedByName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 63 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.ModifiedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 64 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.ModifiedByName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                <td>

                                    <button class=""btn btn-primary btn-sm""><span class=""fas fa-edit""></span> D??zenle</button>
                                    <button class=""btn btn-danger btn-delete btn-sm"" data-id=""");
#nullable restore
#line 68 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                                                                                         Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"fas fa-minus-circle\"></span> Sil</button>\r\n\r\n\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 74 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 80 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
 if (Model.ResultStatus == ResultStatus.Error)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger mt-3\">\r\n        ");
#nullable restore
#line 85 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
   Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        Dashboard sayfas??na geri d??nmek i??in l??tfen ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3939670e0cdd93659fb8bc70da089fa2283af85712726", async() => {
                WriteLiteral("t??klay??n??z");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 88 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

<script>

    $(document).ready(function(){
        $('#categoriesTable').DataTable({
            dom:
               ""<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>"" +
               ""<'row'<'col-sm-12'tr>>"" +
               ""<'row'<'col-sm-5'i><'col-sm-7'p>>"",
            buttons:[
                {
                    text:'Ekle',
                    attr:{
                        id:""btnAdd""
                    },
                    className:'btn btn-success',
                    action:function (e,dt,node,config){

                    }
                },
                 {
                    text:'Yenile',
                    className:'btn btn-warning',
                    action:function (e,dt,node,config){
                        $.ajax(({
                            type:'GET',
                            url:'");
#nullable restore
#line 116 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                            Write(Url.Action("GetAllCategories","Category"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                            contentType:""application/json"",
                            beforeSend:function(){
                                $('#categoriesTable').hide();
                                $('.spinner-border').show();
                            },
                            success:function(data){
                                const categoryListDto=jQuery.parseJSON(data);
                                if(categoryListDto.ResultStatus===0){
                                    let tableBody="""";
                                    $.each(categoryListDto.Categories.$values,function(index,category){
                                        tableBody+=`
                                        <tr>
                                        <td>${category.Id}</td>
                                        <td>${category.Name}</td>
                                        <td>${category.Description}</td>
                                        <td>${convertFirstLetterToUpperCase(categ");
                WriteLiteral(@"ory.IsActive.toString())}</td>
                                        <td>${convertFirstLetterToUpperCase(category.IsDeleted.toString())}</td>
                                        <td>${category.Note}</td>
                                        <td>${convertToShortDate(category.CreatedDate)}</td>
                                        <td>${category.CreatedByName}</td>
                                        <td>${convertToShortDate(category.ModifiedDate)}</td>
                                        <td>${category.ModifiedByName}</td>


                                        </tr>`
                                    })
                                    $('#categoriesTable > tbody').replaceWith(tableBody);
                                    $('.spinner-border').hide();
                                    $('#categoriesTable').fadeIn(1400);
                                }
                                else{
                                    toastr.error(`${categoryListDto.Messa");
                WriteLiteral(@"ge}`,'????lem Ba??ar??s??z!')
                                }
                            },
                            error:function(err){
                               toastr.error(`${err.statusText}`,'????lem Ba??ar??s??z!')
                            }


                        }));
                    }
                }
            ],
            language:{
            ""emptyTable"": ""Tabloda herhangi bir veri mevcut de??il"",
            ""info"": ""_TOTAL_ kay??ttan _START_ - _END_ aras??ndaki kay??tlar g??steriliyor"",
            ""infoEmpty"": ""Kay??t yok"",
            ""infoFiltered"": ""(_MAX_ kay??t i??erisinden bulunan)"",
            ""infoThousands"": ""."",
            ""lengthMenu"": ""Sayfada _MENU_ kay??t g??ster"",
            ""loadingRecords"": ""Y??kleniyor..."",
            ""processing"": ""????leniyor..."",
            ""search"": ""Ara:"",
            ""zeroRecords"": ""E??le??en kay??t bulunamad??"",
            ""paginate"": {
                ""first"": ""??lk"",
                ""last"": ""Son"",
                ""next""");
                WriteLiteral(@": ""Sonraki"",
                ""previous"": ""??nceki""
            },
            ""aria"": {
                ""sortAscending"": "": artan s??tun s??ralamas??n?? aktifle??tir"",
                ""sortDescending"": "": azalan s??tun s??ralamas??n?? aktifle??tir""
            },
            ""select"": {
                ""rows"": {
                    ""_"": ""%d kay??t se??ildi"",
                    ""1"": ""1 kay??t se??ildi""
                },
                ""cells"": {
                    ""1"": ""1 h??cre se??ildi"",
                    ""_"": ""%d h??cre se??ildi""
                },
                ""columns"": {
                    ""1"": ""1 s??tun se??ildi"",
                    ""_"": ""%d s??tun se??ildi""
                }
            },
            ""autoFill"": {
                ""cancel"": ""??ptal"",
                ""fillHorizontal"": ""H??creleri yatay olarak doldur"",
                ""fillVertical"": ""H??creleri dikey olarak doldur"",
                ""fill"": ""B??t??n h??creleri <i>%d<\/i> ile doldur""
            },
            ""buttons"": {
     ");
                WriteLiteral(@"           ""collection"": ""Koleksiyon <span class=\""ui-button-icon-primary ui-icon ui-icon-triangle-1-s\""><\/span>"",
                ""colvis"": ""S??tun g??r??n??rl??????"",
                ""colvisRestore"": ""G??r??n??rl?????? eski haline getir"",
                ""copySuccess"": {
                    ""1"": ""1 sat??r panoya kopyaland??"",
                    ""_"": ""%ds sat??r panoya kopyaland??""
                },
                ""copyTitle"": ""Panoya kopyala"",
                ""csv"": ""CSV"",
                ""excel"": ""Excel"",
                ""pageLength"": {
                    ""-1"": ""B??t??n sat??rlar?? g??ster"",
                    ""_"": ""%d sat??r g??ster""
                },
                ""pdf"": ""PDF"",
                ""print"": ""Yazd??r"",
                ""copy"": ""Kopyala"",
                ""copyKeys"": ""Tablodaki veriyi kopyalamak i??in CTRL veya u2318 + C tu??lar??na bas??n??z. ??ptal etmek i??in bu mesaja t??klay??n veya escape tu??una bas??n."",
                ""createState"": ""??uanki G??r??n??m?? Kaydet"",
                ""removeAllStates"": """);
                WriteLiteral(@"T??m G??r??n??mleri Sil"",
                ""removeState"": ""Aktif G??r??n??m?? Sil"",
                ""renameState"": ""Aktif G??r??n??m??n Ad??n?? De??i??tir"",
                ""savedStates"": ""Kaydedilmi?? G??r??n??mler"",
                ""stateRestore"": ""G??r??n??m -&gt; %d"",
                ""updateState"": ""Aktif G??r??n??m??n G??ncelle""
            },
            ""searchBuilder"": {
                ""add"": ""Ko??ul Ekle"",
                ""button"": {
                    ""0"": ""Arama Olu??turucu"",
                    ""_"": ""Arama Olu??turucu (%d)""
                },
                ""condition"": ""Ko??ul"",
                ""conditions"": {
                    ""date"": {
                        ""after"": ""Sonra"",
                        ""before"": ""??nce"",
                        ""between"": ""Aras??nda"",
                        ""empty"": ""Bo??"",
                        ""equals"": ""E??ittir"",
                        ""not"": ""De??ildir"",
                        ""notBetween"": ""D??????nda"",
                        ""notEmpty"": ""Dolu""
                  ");
                WriteLiteral(@"  },
                    ""number"": {
                        ""between"": ""Aras??nda"",
                        ""empty"": ""Bo??"",
                        ""equals"": ""E??ittir"",
                        ""gt"": ""B??y??kt??r"",
                        ""gte"": ""B??y??k e??ittir"",
                        ""lt"": ""K??????kt??r"",
                        ""lte"": ""K??????k e??ittir"",
                        ""not"": ""De??ildir"",
                        ""notBetween"": ""D??????nda"",
                        ""notEmpty"": ""Dolu""
                    },
                    ""string"": {
                        ""contains"": ""????erir"",
                        ""empty"": ""Bo??"",
                        ""endsWith"": ""??le biter"",
                        ""equals"": ""E??ittir"",
                        ""not"": ""De??ildir"",
                        ""notEmpty"": ""Dolu"",
                        ""startsWith"": ""??le ba??lar"",
                        ""notContains"": ""????ermeyen"",
                        ""notStarts"": ""Ba??lamayan"",
                        ""notEnds"": ""Bitm");
                WriteLiteral(@"eyen""
                    },
                    ""array"": {
                        ""contains"": ""????erir"",
                        ""empty"": ""Bo??"",
                        ""equals"": ""E??ittir"",
                        ""not"": ""De??ildir"",
                        ""notEmpty"": ""Dolu"",
                        ""without"": ""Hari??""
                    }
                },
                ""data"": ""Veri"",
                ""deleteTitle"": ""Filtreleme kural??n?? silin"",
                ""leftTitle"": ""Kriteri d????ar?? ????kart"",
                ""logicAnd"": ""ve"",
                ""logicOr"": ""veya"",
                ""rightTitle"": ""Kriteri i??eri al"",
                ""title"": {
                    ""0"": ""Arama Olu??turucu"",
                    ""_"": ""Arama Olu??turucu (%d)""
                },
                ""value"": ""De??er"",
                ""clearAll"": ""Filtreleri Temizle""
            },
            ""searchPanes"": {
                ""clearMessage"": ""Hepsini Temizle"",
                ""collapse"": {
                    ""0");
                WriteLiteral(@""": ""Arama B??lmesi"",
                    ""_"": ""Arama B??lmesi (%d)""
                },
                ""count"": ""{total}"",
                ""countFiltered"": ""{shown}\/{total}"",
                ""emptyPanes"": ""Arama B??lmesi yok"",
                ""loadMessage"": ""Arama B??lmeleri y??kleniyor ..."",
                ""title"": ""Etkin filtreler - %d"",
                ""showMessage"": ""T??m??n?? G??ster"",
                ""collapseMessage"": ""T??m??n?? Gizle""
            },
            ""thousands"": ""."",
            ""datetime"": {
                ""amPm"": [
                    ""????"",
                    ""??s""
                ],
                ""hours"": ""Saat"",
                ""minutes"": ""Dakika"",
                ""next"": ""Sonraki"",
                ""previous"": ""??nceki"",
                ""seconds"": ""Saniye"",
                ""unknown"": ""Bilinmeyen"",
                ""weekdays"": {
                    ""6"": ""Paz"",
                    ""5"": ""Cmt"",
                    ""4"": ""Cum"",
                    ""3"": ""Per"",
             ");
                WriteLiteral(@"       ""2"": ""??ar"",
                    ""1"": ""Sal"",
                    ""0"": ""Pzt""
                },
                ""months"": {
                    ""9"": ""Ekim"",
                    ""8"": ""Eyl??l"",
                    ""7"": ""A??ustos"",
                    ""6"": ""Temmuz"",
                    ""5"": ""Haziran"",
                    ""4"": ""May??s"",
                    ""3"": ""Nisan"",
                    ""2"": ""Mart"",
                    ""11"": ""Aral??k"",
                    ""10"": ""Kas??m"",
                    ""1"": ""??ubat"",
                    ""0"": ""Ocak""
                }
            },
            ""decimal"": "","",
            ""editor"": {
                ""close"": ""Kapat"",
                ""create"": {
                    ""button"": ""Yeni"",
                    ""submit"": ""Kaydet"",
                    ""title"": ""Yeni kay??t olu??tur""
                },
                ""edit"": {
                    ""button"": ""D??zenle"",
                    ""submit"": ""G??ncelle"",
                    ""title"": ""Kayd?? d??zenle""
    ");
                WriteLiteral(@"            },
                ""error"": {
                    ""system"": ""Bir sistem hatas?? olu??tu (Ayr??nt??l?? bilgi)""
                },
                ""multi"": {
                    ""info"": ""Se??ili kay??tlar bu alanda farkl?? de??erler i??eriyor. Se??ili kay??tlar??n hepsinde bu alana ayn?? de??eri atamak i??in buraya t??klay??n; aksi halde her kay??t bu alanda kendi de??erini koruyacak."",
                    ""noMulti"": ""Bu alan bir grup olarak de??il ancak tekil olarak d??zenlenebilir."",
                    ""restore"": ""De??i??iklikleri geri al"",
                    ""title"": ""??oklu de??er""
                },
                ""remove"": {
                    ""button"": ""Sil"",
                    ""confirm"": {
                        ""_"": ""%d adet kayd?? silmek istedi??inize emin misiniz?"",
                        ""1"": ""Bu kayd?? silmek istedi??inizden emin misiniz?""
                    },
                    ""submit"": ""Sil"",
                    ""title"": ""Kay??tlar?? sil""
                }
            },
            ""s");
                WriteLiteral(@"tateRestore"": {
                ""creationModal"": {
                    ""button"": ""Kaydet"",
                    ""columns"": {
                        ""search"": ""Kolon Aramas??"",
                        ""visible"": ""Kolon G??r??n??m??""
                    },
                    ""name"": ""G??r??n??m ??smi"",
                    ""order"": ""S??ralama"",
                    ""paging"": ""Sayfalama"",
                    ""scroller"": ""Kayd??rma (Scrool)"",
                    ""search"": ""Arama"",
                    ""searchBuilder"": ""Arama Olu??turucu"",
                    ""select"": ""Se??imler"",
                    ""title"": ""Yeni G??r??n??m Olu??tur"",
                    ""toggleLabel"": ""Kaydedilecek Olanlar""
                },
                ""duplicateError"": ""Bu G??r??n??m Daha ??nce Tan??mlanm????"",
                ""emptyError"": ""G??r??n??m Bo?? Olamaz"",
                ""emptyStates"": ""Herhangi Bir G??r??n??m Yok"",
                ""removeConfirm"": ""G??r??n??m?? Silmek ??stedi??inize Eminminisiniz?"",
                ""removeError"": ""G??r??n??m Sil");
                WriteLiteral(@"inemedi"",
                ""removeJoiner"": ""ve"",
                ""removeSubmit"": ""Sil"",
                ""removeTitle"": ""G??r??n??m Sil"",
                ""renameButton"": ""De??i??tir"",
                ""renameLabel"": ""G??r??n??me Yeni ??sim Ver -&gt; %s:"",
                ""renameTitle"": ""G??r??n??m ??smini De??i??tir""
            }
        }

        });

");
                WriteLiteral("\r\n");
                WriteLiteral("             $(function(){\r\n               const url =\'");
#nullable restore
#line 411 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                      Write(Url.Action("Add","Category"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
               const placeHolderDiv=$('#modalPlaceHolder');

                $('#btnAdd').click(function(){

                    $.get(url).done(function(data){
                     placeHolderDiv.html(data);
                     placeHolderDiv.find("".modal"").modal('show');
                    });

                });
");
                WriteLiteral(@"                placeHolderDiv.on('click',
                '#btnSave',
                function(event){
                    event.preventDefault();
                    const form=$('#form-category-add');
                    const actionUrl=form.attr('action');
                    const dataToSend=form.serialize();
                    $.post(actionUrl,dataToSend).done(function(data){
                        const categoryAddAjaxModel=jQuery.parseJSON(data);
                        const newFormBody=$('.modal-body',categoryAddAjaxModel.CategoryAddPartial);
                        placeHolderDiv.find('.modal-body').replaceWith(newFormBody);

                        const isValid=newFormBody.find('#IsValid').val()==='True';

                        if(isValid){


                            placeHolderDiv.find('.modal').modal('hide');
                            const newTableRow=`

                           <tr>
                           <td> ${categoryAddAjaxModel.categoryDto.Category.Id}");
                WriteLiteral(@"</td>
                           <td> ${categoryAddAjaxModel.categoryDto.Category.Name}</td>
                           <td> ${categoryAddAjaxModel.categoryDto.Category.Description}</td>
                           <td> ${convertFirstLetterToUpperCase(categoryAddAjaxModel.categoryDto.Category.IsActive.toString())}</td>
                           <td> ${convertFirstLetterToUpperCase(categoryAddAjaxModel.categoryDto.Category.IsDeleted.toString())}</td>
                           <td> ${categoryAddAjaxModel.categoryDto.Category.Note}</td>
                           <td> ${convertToShortDate(categoryAddAjaxModel.categoryDto.Category.CreatedDate)}</td>
                           <td> ${categoryAddAjaxModel.categoryDto.Category.CreatedByName}</td>
                           <td> ${convertToShortDate(categoryAddAjaxModel.categoryDto.Category.ModifiedDate)}</td>
                           <td> ${categoryAddAjaxModel.categoryDto.Category.ModifiedByName}</td>


                           </tr>`;

         ");
                WriteLiteral(@"                  const newTableRowObject=$(newTableRow);
                           newTableRowObject.hide();
                           $('#categoriesTable').append(newTableRowObject);
                           newTableRowObject.fadeIn(3500);
                           toastr.success(`${categoryAddAjaxModel.categoryDto.Message}`,'Ba??ar??l?? ????lem !')

                        }
                        else{
                            let summaryText="""";
                           $('#validation-summary > ul > li').each(function(){
                               let text=$(this).text();
                               summaryText=`*${text}\n`;
                           });
                           toastr.warning(summaryText);
                        }
                    })
                }
                )
          });
           


");
                WriteLiteral(@"          $(document).on('click','.btn-delete',function(event){

              event.preventDefault();
              const id = $(this).attr('data-id');
              Swal.fire({
              title: 'Silmek istedi??inize emin misiniz?',
              text: ""Se??ili kategori silinecektir!"",
              icon: 'warning',
              showCancelButton: true,
              confirmButtonColor: '#3085d6',
              cancelButtonColor: '#d33',
              confirmButtonText: 'Evet, silmek istiyorum.',
              cancelButtonText:'Hay??r, silmek istemiyorum.'

            }).then((result) => {
                  if (result.isConfirmed) {
                    $.ajax({
                        type:'POST',
                        dataType:'json',
                        data:{categoryId:id},
                        url:'");
#nullable restore
#line 502 "C:\Users\huseyin\source\repos\ProgrammersBlog\ProgrammersBLog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                        Write(Url.Action("Delete","Category"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        success:function(data){

                            const result = jQuery.parseJSON(data);
                            if(result.ResultStatus===0){
                                Swal.fire(
                                    'Silindi',
                                    'Se??ili kategori ba??ar??yla silinmi??tir',
                                    'success'
                                )
                                const tableRow=$(`[name=""${id}""]`);
                                console.log(id);
                                console.log(tableRow);
                                tableRow.fadeOut(3500);
                            }
                            else
                            {
                                Swal.fire({
                                      icon: 'error',
                                      title: 'Bir hata olu??tu.',
                                      text: `${result.Message}`,
                                ");
                WriteLiteral(@"  
                                    })
                             }
                        },
                        error:function(err){

                        }

                    })
                  }
            })




          })
    });



</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProgrammersBLog.Entities.Dtos.CategoryListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
