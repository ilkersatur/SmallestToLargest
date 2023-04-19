List<int> amounts = new List<int>();
//Amounts
IsNullTrnAmounts(Request.CustomCustomerLimitationProfileDetail.PerTrnAmount.ToString()); // Per Trn Amount

IsNullTrnAmounts(Request.CustomCustomerLimitationProfileDetail.DailyTrnAmount.ToString()); // Daily Trn Amount

IsNullTrnAmounts(Request.CustomCustomerLimitationProfileDetail.WeeklyTrnAmount.ToString()); // Weekly Trn Amount

IsNullTrnAmounts(Request.CustomCustomerLimitationProfileDetail.MonthlyTrnAmount.ToString()); // Monthly Trn Amount

IsNullTrnAmounts(Request.CustomCustomerLimitationProfileDetail.YearlyTrnAmount.ToString()); // Yearly Trn Amount

List<int> counts = new List<int>();
//Counts
IsNullTrnCounts(Request.CustomCustomerLimitationProfileDetail.DailyTrnCount.ToString()); // Daily Trn Count

IsNullTrnCounts(Request.CustomCustomerLimitationProfileDetail.WeeklyTrnCount.ToString()); // Weekly Trn Count

IsNullTrnCounts(Request.CustomCustomerLimitationProfileDetail.MonthlyTrnCount.ToString()); // Monthly Trn Count

IsNullTrnCounts(Request.CustomCustomerLimitationProfileDetail.YearlyTrnCount.ToString()); // Yearly Trn Count

List<int> IsNullTrnAmounts(string requests)
{
    if (!string.IsNullOrWhiteSpace(requests))
    {
        int amount = Convert.ToInt32(requests);
        amounts.Add(amount);

    }
    return amounts;
}

List<int> IsNullTrnCounts(string requests)
{
    if (!string.IsNullOrWhiteSpace(requests))
    {
        int count = Convert.ToInt32(requests);
        counts.Add(count);
    }
    return counts;
}

int keepindex = 0;

void IsTrnConsistent(List<int> list)
{
    for (int i = 0; i < list.Count; i++)
    {

        if (keepindex <= list[i])
        {
            keepindex = list[i];
        }
        else
        {
            throw new Exception("Transaction amounts or counts are periodically inconsistent.");
        }
    }
    keepindex = 0;
}

IsTrnConsistent(amounts);
IsTrnConsistent(counts);