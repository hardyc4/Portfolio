/*

	This program lets the user simulate flipping a coin
	1000 times.  Ideally, it should result in 50% heads
	and 50% tails (500 each).
	
*/

function coinFlips()
{
	var totHeads  = 0;			//	Total # head "flips"
	var totTails  = 0;			//	Total # tail "flips"
	var thisFlip  = 0;			//	Current "flip"

	for (lcv = 1; lcv <= 1000; ++lcv)
	{
		thisFlip = Math.round(Math.random());

		if (thisFlip == 0)
		{
			totHeads++;
		}
		else
		{
			totTails++;
		}
	}

	alert ("Total Number of heads: " + totHeads + "\n" +
			"Total number of tails: " + totTails);
}
		