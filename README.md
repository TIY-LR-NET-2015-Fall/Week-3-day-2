# Week-3-day-2
No ReST for the weary
Consuming APIs

Today
-----

1. Linq Examples
1. [Deck of Cards](http://deckofcardsapi.com/)
1. Using [Rest Sharp] (http://restsharp.org/)
```c#
             var client = new RestClient("http://deckofcardsapi.com/api/deck");

            var request = new RestRequest("new/shuffle/?deck_count=1", Method.GET);

            IRestResponse<DeckResponse> response = client.Execute<DeckResponse>(request);
            DeckResponse info = response.Data; 
```

Assignment
----------

Create a console app that connects to the Deck of Cards API above. Your app should:

1. Generate a deck and shuffle it.
2. Deal 5 cards out 3 times to different hands.
3. Show All 3 playes hands. When displaying each hand show the total value of the hand and also display all 5 cards.
4. Indicate which hand has the highest value and what that value is.
5. Show the min and max card for each hand.
6. Display which hand has the most hearts.
* You'll make the request in the Controller, sending data to the View
