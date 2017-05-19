using System.Collections.Generic;
using UnityEngine;

public static class PathFinder
{
	public static List<Grid.Position> FindPath (Tile[,] tiles, Grid.Position fromPosition, Grid.Position toPosition)
	{
		var path = new List<Grid.Position>();
		path.Add( fromPosition );
		path.Add( toPosition );

		while (fromPosition.x != toPosition.x || fromPosition.y != toPosition.y) {

			if (fromPosition.y != toPosition.y) {
				if (fromPosition.y < toPosition.y)
					fromPosition.y++;
				else
					fromPosition.y--;
			}
			if (fromPosition.x != toPosition.x) {
				if (fromPosition.x < toPosition.x)
					fromPosition.x++;
				else
					fromPosition.x--;
			}
			path.Add(fromPosition);
			if (fromPosition.x == toPosition.x && fromPosition.y == toPosition.y) {	
				break;
			}
		}
		return path;
		path.Clear();
	}
}