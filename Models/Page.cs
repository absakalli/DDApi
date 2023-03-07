namespace TodoApi.Models;

public class Page
{
    public Guid id { get; set; }
    public string pageName { get; set; }
    public string backgroundColor { get; set; }
    public decimal pageHeight { get; set; }
    public decimal pageWidth { get; set; }
    public decimal pageWidthPx { get; set; }
    public decimal pageHeightPx { get; set; }

}