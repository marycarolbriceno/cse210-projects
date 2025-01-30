public class Word
{
    // attributes
    private string _text;
    private bool _isHidden;

    // constructor
    public Word(string text)
    {
        _isHidden = false;
        _text = text;
    }

    // methods
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        return _text;
    }
}