
using System.Collections.Immutable;
using Vogen;

ImmutableHashSet<SingleScope> hs = [SingleScope.A, SingleScope.B, SingleScope.C];

var ss = ScopeSet.From(hs);

foreach (var s in ss.Value)
{
    Console.WriteLine(s);
}

return;

[ValueObject<string>]
public readonly partial struct SingleScope
{
    public static readonly SingleScope A = From("A");
    public static readonly SingleScope B = From("B");
    public static readonly SingleScope C = From("C");
}

[ValueObject<ImmutableHashSet<SingleScope>>]
public readonly partial struct ScopeSet;
