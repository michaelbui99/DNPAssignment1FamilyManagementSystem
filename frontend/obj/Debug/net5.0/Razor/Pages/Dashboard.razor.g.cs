#pragma checksum "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Dashboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9b61fd391afdef4d51c30072e0e043ea2cf9298"
// <auto-generated/>
#pragma warning disable 1591
namespace DNPAssignment1FamilyManagementSystem.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using DNPAssignment1FamilyManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using DNPAssignment1FamilyManagementSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Common.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Common.Time;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Interop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Dashboard.razor"
using ChartJs.Blazor.PieChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Dashboard.razor"
using DNPAssignment1FamilyManagementSystem.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Dashboard.razor"
using DNPAssignment1FamilyManagementSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Dashboard.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Dashboard.razor"
using ChartJs.Blazor.BarChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Dashboard.razor"
using ChartJs.Blazor.LineChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Dashboard.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Dashboard.razor"
using ChartJs.Blazor.BarChart.Axes;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Dashboard")]
    public partial class Dashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "<h3 b-gc0yiem2gn>Dashboard</h3>\r\n        ");
                __builder2.AddMarkupContent(3, "<p b-gc0yiem2gn>Welcome to Families Dashboard</p>\r\n        ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "charts-container");
                __builder2.AddAttribute(6, "b-gc0yiem2gn");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "stats-container");
                __builder2.AddAttribute(9, "b-gc0yiem2gn");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "stats-container__stats");
                __builder2.AddAttribute(12, "b-gc0yiem2gn");
                __builder2.AddMarkupContent(13, "<span class=\"oi oi-people\" b-gc0yiem2gn></span>\r\n                    ");
                __builder2.AddMarkupContent(14, "<p b-gc0yiem2gn>Families</p>\r\n                    ");
                __builder2.OpenElement(15, "p");
                __builder2.AddAttribute(16, "b-gc0yiem2gn");
                __builder2.AddContent(17, 
#nullable restore
#line 20 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Dashboard.razor"
                        FamilyStatisticsService.GetTotalAmountOfFamilies()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.AddMarkupContent(19, "<p b-gc0yiem2gn>In Total</p>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n\r\n                ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "stats-container__stats");
                __builder2.AddAttribute(23, "b-gc0yiem2gn");
                __builder2.AddMarkupContent(24, "<span class=\"oi oi-person\" b-gc0yiem2gn></span>\r\n                    ");
                __builder2.AddMarkupContent(25, "<p b-gc0yiem2gn>Adults</p>\r\n                    ");
                __builder2.OpenElement(26, "p");
                __builder2.AddAttribute(27, "b-gc0yiem2gn");
                __builder2.AddContent(28, 
#nullable restore
#line 27 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Dashboard.razor"
                        FamilyStatisticsService.GetTotalAmountOfAdults()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                    ");
                __builder2.AddMarkupContent(30, "<p b-gc0yiem2gn>In Total</p>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n\r\n\r\n                ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "stats-container__stats");
                __builder2.AddAttribute(34, "b-gc0yiem2gn");
                __builder2.AddMarkupContent(35, "<span class=\"oi oi-person\" b-gc0yiem2gn></span>\r\n                    ");
                __builder2.AddMarkupContent(36, "<p b-gc0yiem2gn>Children</p>\r\n                    ");
                __builder2.OpenElement(37, "p");
                __builder2.AddAttribute(38, "b-gc0yiem2gn");
                __builder2.AddContent(39, 
#nullable restore
#line 35 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Dashboard.razor"
                        FamilyStatisticsService.GetTotalAmountOfChildren()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                    ");
                __builder2.AddMarkupContent(41, "<p b-gc0yiem2gn>In Total</p>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n                ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "stats-container__stats");
                __builder2.AddAttribute(45, "b-gc0yiem2gn");
                __builder2.AddMarkupContent(46, "<span class=\"oi oi-bug\" b-gc0yiem2gn></span>\r\n\r\n                    ");
                __builder2.AddMarkupContent(47, "<p b-gc0yiem2gn>Pets</p>\r\n                    ");
                __builder2.OpenElement(48, "p");
                __builder2.AddAttribute(49, "b-gc0yiem2gn");
                __builder2.AddContent(50, 
#nullable restore
#line 43 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Dashboard.razor"
                        FamilyStatisticsService.GetTotalAmountOfPets()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                    ");
                __builder2.AddMarkupContent(52, "<p b-gc0yiem2gn>In Total</p>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n\r\n                ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "stats-container__stats");
                __builder2.AddAttribute(56, "b-gc0yiem2gn");
                __builder2.AddMarkupContent(57, "<span class=\"oi oi-person\" b-gc0yiem2gn></span>\r\n                    ");
                __builder2.AddMarkupContent(58, "<p b-gc0yiem2gn>Average amount of children</p>\r\n                    ");
                __builder2.OpenElement(59, "p");
                __builder2.AddAttribute(60, "b-gc0yiem2gn");
                __builder2.AddContent(61, 
#nullable restore
#line 50 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Dashboard.razor"
                        FamilyStatisticsService.GetAverageChildrenPerFamily()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                    ");
                __builder2.AddMarkupContent(63, "<p b-gc0yiem2gn>Per Family</p>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n\r\n\r\n                ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "chart-stat-container");
                __builder2.AddAttribute(67, "b-gc0yiem2gn");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "b-gc0yiem2gn");
                __builder2.OpenElement(70, "p");
                __builder2.AddAttribute(71, "b-gc0yiem2gn");
                __builder2.AddContent(72, 
#nullable restore
#line 58 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Dashboard.razor"
                            FamilyStatisticsService.GetEyeColorDistribution().Keys.Count

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                        ");
                __builder2.AddMarkupContent(74, "<p b-gc0yiem2gn>Different Eye Colors</p>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                    ");
                __builder2.OpenComponent<ChartJs.Blazor.Chart>(76);
                __builder2.AddAttribute(77, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.Common.ConfigBase>(
#nullable restore
#line 61 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Dashboard.razor"
                                   _eyeColorPieConfig

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "chart-stat-container");
                __builder2.AddAttribute(81, "b-gc0yiem2gn");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "b-gc0yiem2gn");
                __builder2.OpenElement(84, "p");
                __builder2.AddAttribute(85, "b-gc0yiem2gn");
                __builder2.AddContent(86, 
#nullable restore
#line 65 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Dashboard.razor"
                            FamilyStatisticsService.GetAverageSalaryPerFamily()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                        ");
                __builder2.AddMarkupContent(88, "<p b-gc0yiem2gn> Earned on average per family per month</p>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                    ");
                __builder2.OpenComponent<ChartJs.Blazor.Chart>(90);
                __builder2.AddAttribute(91, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.Common.ConfigBase>(
#nullable restore
#line 68 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Dashboard.razor"
                                   _salaryPieConfig

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\Dashboard.razor"
       
    private PieConfig _eyeColorPieConfig;
    private PieConfig _salaryPieConfig;

    protected override Task OnInitializedAsync()
    {
        InitEyeColorDistributionEyeChart();
        InitSalaryPieChart();
        return base.OnInitializedAsync();
    }


    private void InitEyeColorDistributionEyeChart()
    {
    //Creating a new PieConfig
        _eyeColorPieConfig = new PieConfig()
        {
            Options = new PieOptions()
            {
                Responsive = true,
                Title = new OptionsTitle()
                {
                    Display = true,
                    Text = "Eye Color Distribution",
                    FontColor = "white"
                },
                Legend = new Legend()
                {
                    Labels = new LegendLabels()
                    {
                        FontColor = "white"
                    }
                }
            }
        };

    //Adding Chart Labels
        foreach (string color in FamilyStatisticsService.GetEyeColorDistribution().Keys)
        {
            _eyeColorPieConfig.Data.Labels.Add(color);
        }


    //TODO: Find a solution to adding unspecified HTML colors without a chain of if-statements 
    /*
         *Dynamically adding color to pie slices depending on the eye color
         * The Data set contains eye colors that are not known colors defined by HTML specifications
         * resulting in the chain of if-statements as a temp fix
         */
        IList<String> eyeColorsAsColorExStrings = new List<string>();
        foreach (var key in FamilyStatisticsService.GetEyeColorDistribution().Keys)
        {
            Color color;
            if (key.ToLower() == "grey")
            {
                color = Color.FromName("Gray");
            }
            else if (key.ToLower() == "amber")
            {
                color = Color.FromArgb(255, 191, 0);
            }
            else if (key.ToLower() == "hazel")
            {
                color = Color.FromArgb(201, 199, 137);
            }
            else
            {
                color = Color.FromName(key);
            }
            eyeColorsAsColorExStrings.Add(ColorUtil.ColorString(color.R, color.G, color.B));
        }

        PieDataset<int> dataset = new PieDataset<int>(FamilyStatisticsService.GetEyeColorDistribution().Values)
        {
            BackgroundColor = eyeColorsAsColorExStrings.ToArray()
        };

        _eyeColorPieConfig.Data.Datasets.Add(dataset);
    }

    private void InitSalaryPieChart()
    {
        _salaryPieConfig = new PieConfig()
        {
            Options = new PieOptions()
            {
                Responsive = true, Title = new OptionsTitle()
                {
                    Display = true, Text = "Salary Distribution", FontColor = "white"
                },
                Legend = new Legend()
                {
                    Labels = new LegendLabels()
                    {
                        FontColor = "white"
                    }
                }
            }
        };

        foreach (var keyValuePair in FamilyStatisticsService.GetSalaryDistribution())
        {
            _salaryPieConfig.Data.Labels.Add(keyValuePair.Key);
        }

        string[] knownColors = Enum.GetNames(typeof(System.Drawing.KnownColor));
        List<string> knownColorsAsHexStrings = new List<string>();
        
        foreach (var knownColor in knownColors)
        {
            Color color = Color.FromName(knownColor);
            knownColorsAsHexStrings.Add(ColorUtil.ColorHexString(color.R, color.G, color.B)); 
        }
        knownColorsAsHexStrings.Reverse();
        PieDataset<decimal> salaryDataSet = new PieDataset<decimal>(FamilyStatisticsService.GetSalaryDistribution().Values)
        {
            BackgroundColor = knownColorsAsHexStrings.ToArray()
        };
        
        _salaryPieConfig.Data.Datasets.Add(salaryDataSet);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyStatisticsService FamilyStatisticsService { get; set; }
    }
}
#pragma warning restore 1591