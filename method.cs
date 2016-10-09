// method returns true or false if player has been hit
public void isHit(int x, int y)
{
	if (player.position(x, y))
	{
		player.life - dmg;
	}
}
