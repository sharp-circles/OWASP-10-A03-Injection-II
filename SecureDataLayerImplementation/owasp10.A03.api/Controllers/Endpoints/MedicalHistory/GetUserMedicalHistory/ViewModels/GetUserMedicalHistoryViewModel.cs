namespace owasp10.A03.api.Controllers.Endpoints.MedicalHistory.GetUserMedicalHistory.ViewModels;

public record GetUserMedicalHistoryViewModel
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public string UserName { get; set; }
    public sbyte Age { get; set; }
    public string Treatment { get; set; }
    public string Affection { get; set; }
    public string UndergoneSurgery { get; set; }
}
