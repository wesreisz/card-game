using cardpicker_project;

Stack <Card> gameDeck = new Deck().Shuffle();


Console.Out.WriteLine("Initial Size: " + gameDeck.Count);

int counter = gameDeck.Count;

for (int i = 0; i < counter; i++) {
    Console.Out.WriteLine(gameDeck.Peek());
    gameDeck.Pop();
}

Console.Out.WriteLine("Final Size: " + gameDeck.Count);
