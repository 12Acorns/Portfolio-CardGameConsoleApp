﻿using GameOne._Player;
using Deck.Deck.Card;

namespace Renderer;

internal sealed class GameRenderer
{
	private const string DISCARDPILE = $"{DOWNARROW} Discard Deck: {DOWNARROW}";
	private const string PLAYERDECK = $"{DOWNARROW} Your Deck: {DOWNARROW}";
	private const string DOWNARROW = "\u0019";

	public GameRenderer(Player[] _players, Player _player)
	{
		players = _players;
		player = _player;
	}

	private readonly Player[] players;
	private readonly Player player;

	public void Render(Player _currentPlayer, GameCard _currentCard, GameCard _discardCard)
	{
		RenderPlayerInfo(_currentPlayer);
		if(player.IsTurn)
		{
			Console.WriteLine(PLAYERDECK);
			RenderCard(_currentCard);
		}
		Console.WriteLine(DISCARDPILE);
		RenderCard(_discardCard);
	}

	private static void RenderCard(GameCard _card)
	{
		Console.Write(CardRender.Render(_card));
		Console.Write('\n');
	}
	private void RenderPlayerInfo(Player _currentPlaying)
	{
		Console.Write(PlayerRender.FormatPlayers(players, _currentPlaying));
		Console.Write('\n');
	}
}
