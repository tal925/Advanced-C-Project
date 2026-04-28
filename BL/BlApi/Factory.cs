using DalApi;

namespace BlApi;

// השורה הזו מחברת בין הממשק למימוש בפועל של ה-BL
public static class Factory
{
    // מחזיר מופע של המימוש הפנימי של השכבה הלוגית
    public static IBl Get() => new BlImplementation.Bl();
}
