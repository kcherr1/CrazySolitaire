using CrazySolitaire.Properties;

namespace CrazySolitaire;

public enum CardType {
    ACE,
    _2,
    _3,
    _4,
    _5,
    _6,
    _7,
    _8,
    _9,
    _10,
    JACK,
    QUEEN,
    KING
}

public enum Suit {
    DIAMONDS,
    SPADES,
    HEARTS,
    CLUBS
}

public static class MyExtensions {
    public static void AddCard(this Control control, Card card) {
        if (card is not null) {
            control.Controls.Add(card.PicBox);
        }
    }
    public static void RemCard(this Control control, Card card) {
        if (card is not null) {
            control.Controls.Remove(card.PicBox);
        }
    }
}

public class Deck {
    private Queue<Card> cards;

    public Deck() {
        RegeneratePool();
    }

    private void RegeneratePool() {
        cards = new();
        foreach (var cardType in Enum.GetValues<CardType>()) {
            foreach (var suit in Enum.GetValues<Suit>()) {
                cards.Enqueue(new(cardType, suit));
            }
        }
    }

    public Card Acquire() => (cards.Count > 0 ? cards.Dequeue() : null);
    public void Release(Card c) => cards.Enqueue(c);    
}

public class Card {
    public CardType Type { get; private set; }
    public Suit Suit { get; private set; }
    public bool FaceUp { get; private set; }
    public PictureBox PicBox { get; private set; }
    public Bitmap PicImg {
        get => FaceUp ? Resources.ResourceManager.GetObject($"{Type.ToString().Replace("_","").ToLower()}_of_{Suit.ToString().ToLower()}") as Bitmap
                      : Resources.back_green;
    }

    public Card(CardType type, Suit suit) {
        Type = type;
        Suit = suit;
        FaceUp = true;
        SetupPicBox();
    }

    private void SetupPicBox() {
        PicBox = new() {
            Width = 90,
            Height = 126,
            BackgroundImageLayout = ImageLayout.Stretch,
            BorderStyle = BorderStyle.FixedSingle,
            BackgroundImage = PicImg
        };
        PicBox.Click += (sender, e) => FlipOver();
    }

    public void FlipOver() {
        FaceUp = !FaceUp;
        PicBox.BackgroundImage = PicImg;
    }
}

public class TableauStack {
    public LinkedList<Card> cards;
}

public class Game {
    public Deck Deck { get; private set; }
    public Dictionary<Suit, Stack<Card>> FoundationStacks { get; set; }
    public TableauStack[] TableauStacks;

    public Game() {
        Deck = new();
    }
}
