public struct LinkItem
{
    public string Href { get; set; }
    public string Text { get; set; }

    public LinkItem(string href, string text)
    {
        Href = href;
        Text = text;
    }
}
