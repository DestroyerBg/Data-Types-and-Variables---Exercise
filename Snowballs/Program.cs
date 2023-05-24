int numberOfSnowballs=int.Parse(Console.ReadLine());
int snowBallSnow = 0;
int snowBallTime = 0;
int snowBallQuality = 0;
double snowBallSnowAndTime = 0;
double snowBallFormula = 0;
double bestSnowBall = double.MinValue;
double bestSnowBallSnow= double.MinValue;
double bestSnowBallTime= double.MinValue;
double bestSnowBallQuality= double.MinValue;

for (int i = 1; i <= numberOfSnowballs; i++)
{
     snowBallSnow = int.Parse(Console.ReadLine());
     snowBallTime = int.Parse(Console.ReadLine());
     snowBallQuality = int.Parse(Console.ReadLine());
     snowBallSnowAndTime = (snowBallSnow / snowBallTime);
    snowBallFormula =Math.Pow(snowBallSnowAndTime, snowBallQuality);
    if (snowBallFormula>bestSnowBall)
    {
        bestSnowBall = snowBallFormula;
        bestSnowBallSnow= snowBallSnow;
        bestSnowBallTime = snowBallTime;
        bestSnowBallQuality = snowBallQuality;

    }
}
Console.WriteLine($"{bestSnowBallSnow} : {bestSnowBallTime} = {bestSnowBall} ({bestSnowBallQuality})");

