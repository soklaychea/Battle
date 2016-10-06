public void isHit(int x, int y, int dmg)
{
	if (player.position(x, y))
	{
		player.life - dmg;
	}
}

