﻿using Terminal.Gui;

namespace TerminalGuiDesigner.Operations.Generics;

/// <summary>
/// Describes a <see cref="View"/> specific operation (can only be run on a given Type
/// of view (e.g. <see cref="TableView"/>).
/// </summary>
/// <typeparam name="T">Type of <see cref="View"/> the <see cref="Operation"/> runs on.</typeparam>
public abstract class GenericOperation<T> : Operation
        where T : View
{
    /// <summary>
    /// Gets the <see cref="Design"/> which will be operated on by this operation.  The
    /// <see cref="Design.View"/> will be a <typeparamref name="T"/>.
    /// </summary>
    protected Design Design { get; }

    /// <summary>
    /// Gets the <typeparamref name="T"/> (wrapped by <see cref="Design"/>) that
    /// will be operated on.
    /// </summary>
    protected T View { get; }

    public GenericOperation(Design design)
    {
        if (design.View is not T t)
        {
            throw new ArgumentException($"Design must wrap a {typeof(T).Name} to be used with this operation.");
        }

        this.View = t;
    }
}
