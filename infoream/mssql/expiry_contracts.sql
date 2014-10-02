--Expired contracts
select agr_code from r5agreements where agr_end < cast(getdate() as date);

--Expiring contracts in next month
select agr_code from r5agreements where agr_end > cast(getdate() as date) and agr_end < dateadd(month, 1, cast(getdate() as date));