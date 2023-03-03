namespace TodoApi.Models;

public class Element
{
    public Guid id { get; set; }
    public string tip { get; set; }
    public short top { get; set; }
    public short left { get; set; }
    public string? span { get; set; }
    public string font { get; set; }
    public short punto { get; set; }
    public string? fontWeight { get; set; }
    public string? fontStyle { get; set; }
    public string? textDecor { get; set; }
    public short? spanTop { get; set; }
    public short? spanLeft { get; set; }
    public short? spanRight { get; set; }
    public short? spanBottom { get; set; }
    public short layer { get; set; }
    public long height { get; set; }
    public long width { get; set; }
    public string spanLoc { get; set; }
    public string? bgColor { get; set; }
    public string? bgUrl { get; set; }
    public string bg { get; set; }
}