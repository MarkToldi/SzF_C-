public class WorkModel
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public string LicensePlate { get; set; } = string.Empty;
    public int ManufacturingYear { get; set; }
    public string Category { get; set; } = string.Empty;
     public string Description { get; set; } = string.Empty;
    public int Severity { get; set; }
    public string Status { get; set; } = string.Empty;
}
