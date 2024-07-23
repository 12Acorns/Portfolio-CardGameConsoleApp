﻿namespace CardGameConsoleApp.Deck.Card;

internal record CardDescription
{
	public CardDescription(CardType _type, CardColour _colour, Dictionary<CardSubType, byte> _cardCountMapping)
	{
		Type = _type;
		Colour = _colour;
		CardCountMapping = _cardCountMapping.AsReadOnly();
		TotalCount = CardCountMapping.Values.Sum(x => x);
	}

	public CardType Type { get; }
	public CardColour Colour { get; }
	public IReadOnlyDictionary<CardSubType, byte> CardCountMapping { get; }
	public int TotalCount { get; }
}
