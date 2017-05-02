CREATE FUNCTION ufn_CalcSum(@sum decimal, @yearlyInterestRate float, @months int)
	RETURNS decimal
AS
BEGIN
	RETURN (((@yearlyInterestRate / 12) * @months) * @sum) + @sum
END