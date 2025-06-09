using owasp10.A03.business.UseCases.GetUserMedicalHistoryRecords.Dtos;

namespace owasp10.A03.business.UseCases.GetUserMedicalHistoryRecords.Contracts;

public interface IGetUserMedicalHistoryRecordsInteractor
{
    Task<IEnumerable<GetUserMedicalHistoryRecordsOutput>> Handle(GetUserMedicalHistoryRecordsInput getUserMedicalHistoryRecordsInput);
}
