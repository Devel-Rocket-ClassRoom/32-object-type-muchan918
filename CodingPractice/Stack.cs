using System;

class Stack
{
    private int _position;
    private object[] _data = new object[10];

    public void Push(object obj)
    {
        _data[_position++] = obj;
    }

    public object Pop()
    {
        return _data[--_position];
    }
}