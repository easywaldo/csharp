public interface NumberStringSequence : IntegerSequence
{
    bool hasNext();
    int next();
    string charNext();
}