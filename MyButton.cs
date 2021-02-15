using System;

public class MyButton
{
    private EventHandler _click;
    public event EventHandler Click
    {
        add
        {
            _click += value;
        }
        remove
        {
            _click -= value;
        }
    }

    public string Text { get; set; }

    public void MouseButtonDown()
    {
        if (this._click != null)
        {
            _click(this, EventArgs.Empty);
        }
    }
}