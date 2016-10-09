// method returns true or false if player has been hit
public bool isHit(int x, int y)
{
	if (player.position(x, y))
	{
		return true;
	}
	else
	{
		return false;
	}
}