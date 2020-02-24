using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ColorRoomManager.Reports.Object;
using System.Collections.Generic;

/// <summary>
/// Summary description for rptMixing
/// </summary>
public class rptMixing : DevExpress.XtraReports.UI.XtraReport
{
    private TopMarginBand TopMargin;
    private XRPanel txtSoMay;
    private XRLabel txtItemName;
    private XRLabel xrLabel1;
    private XRLabel txtMachineInfo;
    private XRLabel txtBatchNo;
    private XRLabel xrLabel4;
    private XRLine xrLine10;
    private XRLine xrLine2;
    private XRLabel xrLabel6;
    private XRLabel xrLabel5;
    private XRLabel txtScaleWeight;
    private XRLabel txtMaterialName;
    private XRLabel txtColorCode;
    private XRLine xrLine6;
    private XRLabel txtBarcodeDisplay;
    private XRLine xrLine16;
    private XRLabel txtLabelName;
    private XRLabel xrLabel8;
    private XRLine xrLine11;
    private XRLabel txtColorName;
    private XRLabel xrLabel3;
    private XRLine xrLine9;
    private XRLine xrLine5;
    private XRLine xrLine4;
    private XRLine xrLine3;
    private XRLine xrLine1;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private XRBarCode xrBarCode;
    private XRPageInfo xrPageInfo1;
    private XRLine xrLine8;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public rptMixing()
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.txtSoMay = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLine8 = new DevExpress.XtraReports.UI.XRLine();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrBarCode = new DevExpress.XtraReports.UI.XRBarCode();
            this.txtItemName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtMachineInfo = new DevExpress.XtraReports.UI.XRLabel();
            this.txtBatchNo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine10 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtScaleWeight = new DevExpress.XtraReports.UI.XRLabel();
            this.txtMaterialName = new DevExpress.XtraReports.UI.XRLabel();
            this.txtColorCode = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine6 = new DevExpress.XtraReports.UI.XRLine();
            this.txtBarcodeDisplay = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine16 = new DevExpress.XtraReports.UI.XRLine();
            this.txtLabelName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine11 = new DevExpress.XtraReports.UI.XRLine();
            this.txtColorName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine9 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtSoMay});
            this.Detail.HeightF = 442.7046F;
            this.Detail.Name = "Detail";
            this.Detail.Visible = false;
            // 
            // txtSoMay
            // 
            this.txtSoMay.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.txtSoMay.CanGrow = false;
            this.txtSoMay.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine8,
            this.xrPageInfo1,
            this.xrBarCode,
            this.txtItemName,
            this.xrLabel1,
            this.txtMachineInfo,
            this.txtBatchNo,
            this.xrLabel4,
            this.xrLine10,
            this.xrLine2,
            this.xrLabel6,
            this.xrLabel5,
            this.txtScaleWeight,
            this.txtMaterialName,
            this.txtColorCode,
            this.xrLine6,
            this.txtBarcodeDisplay,
            this.xrLine16,
            this.txtLabelName,
            this.xrLabel8,
            this.xrLine11,
            this.txtColorName,
            this.xrLabel3,
            this.xrLine9,
            this.xrLine5,
            this.xrLine4,
            this.xrLine3,
            this.xrLine1});
            this.txtSoMay.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.txtSoMay.Name = "txtSoMay";
            this.txtSoMay.SizeF = new System.Drawing.SizeF(400F, 432.7046F);
            // 
            // xrLine8
            // 
            this.xrLine8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine8.BorderWidth = 1.5F;
            this.xrLine8.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine8.LocationFloat = new DevExpress.Utils.PointFloat(70.33342F, 48.00002F);
            this.xrLine8.Name = "xrLine8";
            this.xrLine8.SizeF = new System.Drawing.SizeF(2F, 260.0833F);
            this.xrLine8.StylePriority.UseBorders = false;
            this.xrLine8.StylePriority.UseBorderWidth = false;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.xrPageInfo1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic);
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(233.9581F, 398.4999F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(128.8754F, 20.00003F);
            this.xrPageInfo1.StylePriority.UseBorderDashStyle = false;
            this.xrPageInfo1.StylePriority.UseBorders = false;
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrPageInfo1.TextFormatString = " {0:h:mm tt; dd MMMM yyyy}";
            // 
            // xrBarCode
            // 
            this.xrBarCode.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode.AutoModule = true;
            this.xrBarCode.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode.BorderWidth = 1F;
            this.xrBarCode.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BarCode]")});
            this.xrBarCode.Font = new System.Drawing.Font("Arial", 16F);
            this.xrBarCode.LocationFloat = new DevExpress.Utils.PointFloat(275.0417F, 310.1667F);
            this.xrBarCode.Name = "xrBarCode";
            this.xrBarCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrBarCode.ShowText = false;
            this.xrBarCode.SizeF = new System.Drawing.SizeF(90.7084F, 88.33325F);
            this.xrBarCode.StylePriority.UseBorders = false;
            this.xrBarCode.StylePriority.UseBorderWidth = false;
            this.xrBarCode.StylePriority.UseFont = false;
            this.xrBarCode.StylePriority.UseTextAlignment = false;
            this.xrBarCode.Symbology = qrCodeGenerator1;
            this.xrBarCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // txtItemName
            // 
            this.txtItemName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtItemName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.LocationFloat = new DevExpress.Utils.PointFloat(77.8333F, 120.8333F);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 2, 100F);
            this.txtItemName.SizeF = new System.Drawing.SizeF(285.0001F, 47.08331F);
            this.txtItemName.StylePriority.UseBorders = false;
            this.txtItemName.StylePriority.UseFont = false;
            this.txtItemName.StylePriority.UsePadding = false;
            this.txtItemName.Text = "Zoom Victory 3/Zoom Victory Elite 2  Plate (72R53)";
            // 
            // xrLabel1
            // 
            this.xrLabel1.BorderColor = System.Drawing.Color.Silver;
            this.xrLabel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(16.62503F, 16.00002F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(52.62496F, 29.08333F);
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Số Máy";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // txtMachineInfo
            // 
            this.txtMachineInfo.BorderColor = System.Drawing.Color.Silver;
            this.txtMachineInfo.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.txtMachineInfo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.txtMachineInfo.LocationFloat = new DevExpress.Utils.PointFloat(82.79164F, 16.00002F);
            this.txtMachineInfo.Multiline = true;
            this.txtMachineInfo.Name = "txtMachineInfo";
            this.txtMachineInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtMachineInfo.SizeF = new System.Drawing.SizeF(282.9584F, 27F);
            this.txtMachineInfo.StylePriority.UseBorderColor = false;
            this.txtMachineInfo.StylePriority.UseBorders = false;
            this.txtMachineInfo.StylePriority.UseFont = false;
            this.txtMachineInfo.StylePriority.UseTextAlignment = false;
            this.txtMachineInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.txtBatchNo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.txtBatchNo.LocationFloat = new DevExpress.Utils.PointFloat(272.125F, 283.0833F);
            this.txtBatchNo.Multiline = true;
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtBatchNo.SizeF = new System.Drawing.SizeF(73.37497F, 20F);
            this.txtBatchNo.StylePriority.UseBorders = false;
            this.txtBatchNo.StylePriority.UseFont = false;
            this.txtBatchNo.StylePriority.UseTextAlignment = false;
            this.txtBatchNo.Text = "0";
            this.txtBatchNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(272.125F, 257.2083F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(73.37497F, 20.00002F);
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Batch No";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLine10
            // 
            this.xrLine10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine10.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine10.LocationFloat = new DevExpress.Utils.PointFloat(70.25008F, 14.16667F);
            this.xrLine10.Name = "xrLine10";
            this.xrLine10.SizeF = new System.Drawing.SizeF(2.083328F, 35.91668F);
            this.xrLine10.StylePriority.UseBorders = false;
            // 
            // xrLine2
            // 
            this.xrLine2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(71.75F, 169.9166F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(301.3334F, 2.083328F);
            this.xrLine2.StylePriority.UseBorders = false;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(76.75F, 283.0833F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(54.62497F, 20F);
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "(Kg)";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(76.75F, 257.2083F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(54.62497F, 20F);
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Q\'ty";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // txtScaleWeight
            // 
            this.txtScaleWeight.BorderColor = System.Drawing.Color.Silver;
            this.txtScaleWeight.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.txtScaleWeight.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.txtScaleWeight.LocationFloat = new DevExpress.Utils.PointFloat(136.9583F, 255.2083F);
            this.txtScaleWeight.Multiline = true;
            this.txtScaleWeight.Name = "txtScaleWeight";
            this.txtScaleWeight.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtScaleWeight.SizeF = new System.Drawing.SizeF(104.1667F, 47.875F);
            this.txtScaleWeight.StylePriority.UseBorderColor = false;
            this.txtScaleWeight.StylePriority.UseBorders = false;
            this.txtScaleWeight.StylePriority.UseFont = false;
            this.txtScaleWeight.StylePriority.UseTextAlignment = false;
            this.txtScaleWeight.Text = "15";
            this.txtScaleWeight.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.BorderColor = System.Drawing.Color.Silver;
            this.txtMaterialName.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.txtMaterialName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterialName.LocationFloat = new DevExpress.Utils.PointFloat(131.375F, 171.9999F);
            this.txtMaterialName.Multiline = true;
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtMaterialName.SizeF = new System.Drawing.SizeF(234.3751F, 79.12505F);
            this.txtMaterialName.StylePriority.UseBorderColor = false;
            this.txtMaterialName.StylePriority.UseBorders = false;
            this.txtMaterialName.StylePriority.UseFont = false;
            this.txtMaterialName.StylePriority.UseTextAlignment = false;
            this.txtMaterialName.Text = "Zoom Victory 3/Zoom Victory Elite 2  Plate (72R53)";
            this.txtMaterialName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // txtColorCode
            // 
            this.txtColorCode.BorderColor = System.Drawing.Color.Silver;
            this.txtColorCode.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.txtColorCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtColorCode.LocationFloat = new DevExpress.Utils.PointFloat(82.79161F, 86.54169F);
            this.txtColorCode.Multiline = true;
            this.txtColorCode.Name = "txtColorCode";
            this.txtColorCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtColorCode.SizeF = new System.Drawing.SizeF(48.58334F, 22.87499F);
            this.txtColorCode.StylePriority.UseBorderColor = false;
            this.txtColorCode.StylePriority.UseBorders = false;
            this.txtColorCode.StylePriority.UseFont = false;
            this.txtColorCode.StylePriority.UseTextAlignment = false;
            this.txtColorCode.Text = "2000";
            this.txtColorCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLine6
            // 
            this.xrLine6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine6.LocationFloat = new DevExpress.Utils.PointFloat(10.625F, 308.0833F);
            this.xrLine6.Name = "xrLine6";
            this.xrLine6.SizeF = new System.Drawing.SizeF(359.375F, 2.083332F);
            this.xrLine6.StylePriority.UseBorders = false;
            // 
            // txtBarcodeDisplay
            // 
            this.txtBarcodeDisplay.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtBarcodeDisplay.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcodeDisplay.LocationFloat = new DevExpress.Utils.PointFloat(16.62502F, 398.4999F);
            this.txtBarcodeDisplay.Multiline = true;
            this.txtBarcodeDisplay.Name = "txtBarcodeDisplay";
            this.txtBarcodeDisplay.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtBarcodeDisplay.SizeF = new System.Drawing.SizeF(169.7915F, 20F);
            this.txtBarcodeDisplay.StylePriority.UseBorders = false;
            this.txtBarcodeDisplay.StylePriority.UseFont = false;
            this.txtBarcodeDisplay.Text = "*11111111-888*";
            // 
            // xrLine16
            // 
            this.xrLine16.LocationFloat = new DevExpress.Utils.PointFloat(10.62501F, 423.8333F);
            this.xrLine16.Name = "xrLine16";
            this.xrLine16.SizeF = new System.Drawing.SizeF(359.375F, 2.083344F);
            // 
            // txtLabelName
            // 
            this.txtLabelName.Angle = 90F;
            this.txtLabelName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtLabelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtLabelName.LocationFloat = new DevExpress.Utils.PointFloat(16.62503F, 50.08336F);
            this.txtLabelName.Multiline = true;
            this.txtLabelName.Name = "txtLabelName";
            this.txtLabelName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtLabelName.SizeF = new System.Drawing.SizeF(48.70832F, 257.9999F);
            this.txtLabelName.StylePriority.UseBorders = false;
            this.txtLabelName.StylePriority.UseFont = false;
            this.txtLabelName.StylePriority.UseTextAlignment = false;
            this.txtLabelName.Text = "RUNNER (CUỐN NHỰA)";
            this.txtLabelName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(73.83329F, 205.5F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(57.54163F, 20F);
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Polymer";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine11
            // 
            this.xrLine11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine11.LocationFloat = new DevExpress.Utils.PointFloat(73.8333F, 251.125F);
            this.xrLine11.Name = "xrLine11";
            this.xrLine11.SizeF = new System.Drawing.SizeF(298.1667F, 2.083328F);
            this.xrLine11.StylePriority.UseBorders = false;
            // 
            // txtColorName
            // 
            this.txtColorName.BorderColor = System.Drawing.Color.Silver;
            this.txtColorName.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.txtColorName.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.txtColorName.LocationFloat = new DevExpress.Utils.PointFloat(136.9583F, 50.08336F);
            this.txtColorName.Multiline = true;
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtColorName.SizeF = new System.Drawing.SizeF(225.8752F, 59.33332F);
            this.txtColorName.StylePriority.UseBorderColor = false;
            this.txtColorName.StylePriority.UseBorders = false;
            this.txtColorName.StylePriority.UseFont = false;
            this.txtColorName.StylePriority.UseTextAlignment = false;
            this.txtColorName.Text = "Color";
            this.txtColorName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(82.79163F, 62.54168F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(48.58334F, 15.44275F);
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Color";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLine9
            // 
            this.xrLine9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine9.LocationFloat = new DevExpress.Utils.PointFloat(73.8333F, 114.4167F);
            this.xrLine9.Name = "xrLine9";
            this.xrLine9.SizeF = new System.Drawing.SizeF(299.2501F, 2.083336F);
            this.xrLine9.StylePriority.UseBorders = false;
            // 
            // xrLine5
            // 
            this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(12.625F, 48.00002F);
            this.xrLine5.Name = "xrLine5";
            this.xrLine5.SizeF = new System.Drawing.SizeF(359.375F, 2.083332F);
            // 
            // xrLine4
            // 
            this.xrLine4.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(369.9999F, 10.00001F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(2.083344F, 413.8333F);
            // 
            // xrLine3
            // 
            this.xrLine3.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(10.62501F, 12.08334F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(2.083334F, 413.8333F);
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 10.00001F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(359.375F, 2.083333F);
            // 
            // rptMixing
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 1, 0, 0);
            this.PageHeight = 693;
            this.PageWidth = 402;
            this.PaperKind = System.Drawing.Printing.PaperKind.PrcEnvelopeNumber2;
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    public void Load(List<LabelTemplate> List)
    {
        foreach (var Item in List)
        {
            Item.MaterialName = Item.MaterialName;
        }
        this.DataSource = List;
        LoadDetail();
    }

    public void LoadDetail()
    {
        this.txtLabelName.DataBindings.Add(new DevExpress.XtraReports.UI.XRBinding("Text", null, "LabelName"));
        this.txtItemName.DataBindings.Add(new DevExpress.XtraReports.UI.XRBinding("Text", null, "ProductName"));
        this.txtColorName.DataBindings.Add(new DevExpress.XtraReports.UI.XRBinding("Text", null, "ColorName"));
        this.txtMaterialName.DataBindings.Add(new DevExpress.XtraReports.UI.XRBinding("Text", null, "MaterialName"));
        this.txtScaleWeight.DataBindings.Add(new DevExpress.XtraReports.UI.XRBinding("Text", null, "WeightMix", "{0:#,###.0}"));
        this.txtMachineInfo.DataBindings.Add(new DevExpress.XtraReports.UI.XRBinding("Text", null, "MaterialName"));
        this.xrBarCode.DataBindings.Add(new DevExpress.XtraReports.UI.XRBinding("Text", null, "MixBacode"));
    }
}
