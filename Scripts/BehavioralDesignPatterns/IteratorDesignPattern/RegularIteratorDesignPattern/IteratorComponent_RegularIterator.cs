namespace VisualStudio_DesignPatternsInCSharp.Scripts.BehavioralDesignPatterns.IteratorDesignPattern.RegularIteratorDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class IteratorComponent<Template1> where Template1 : class
    {
        private NodeComponent<Template1> IteratorComponentRoot { get; }

        private IteratorComponent() : base()
        {

        }

        public IteratorComponent(in NodeComponent<Template1> iteratorComponentRoot) : base()
        {
            IteratorComponentRoot = iteratorComponentRoot;
        }

        public IEnumerable<NodeComponent<Template1>> GetIteratorComponentPreOrderCollection()
        {
            static IEnumerable<NodeComponent<Template1>> GetIteratorComponentPreOrderCollection(NodeComponent<Template1> iteratorComponentCurrent)
            {
                if (iteratorComponentCurrent is null)
                {
                    yield break;
                }

                yield return iteratorComponentCurrent;

                if (iteratorComponentCurrent.CheckNodeComponentLeftIsNotNull(nodeComponentLeft: out NodeComponent<Template1> iteratorComponentLeft))
                {
                    foreach (NodeComponent<Template1> iteratorComponentChild in GetIteratorComponentPreOrderCollection(iteratorComponentCurrent: iteratorComponentLeft))
                    {
                        yield return iteratorComponentChild;
                    }
                }

                if (iteratorComponentCurrent.CheckNodeComponentRightIsNotNull(nodeComponentRight: out NodeComponent<Template1> iteratorComponentRight))
                {
                    foreach (NodeComponent<Template1> iteratorComponentChild in GetIteratorComponentPreOrderCollection(iteratorComponentCurrent: iteratorComponentRight))
                    {
                        yield return iteratorComponentChild;
                    }
                }
            }

            if (IteratorComponentRoot is null)
            {
                yield break;
            }

            foreach (NodeComponent<Template1> iteratorComponentChild in GetIteratorComponentPreOrderCollection(iteratorComponentCurrent: IteratorComponentRoot))
            {
                yield return iteratorComponentChild;
            }
        }

        public IEnumerable<NodeComponent<Template1>> GetIteratorComponentInOrderCollection()
        {
            static IEnumerable<NodeComponent<Template1>> GetIteratorComponentInOrderCollection(NodeComponent<Template1> iteratorComponentCurrent)
            {
                if (iteratorComponentCurrent is null)
                {
                    yield break;
                }

                if (iteratorComponentCurrent.CheckNodeComponentLeftIsNotNull(nodeComponentLeft: out NodeComponent<Template1> iteratorComponentLeft))
                {
                    foreach (NodeComponent<Template1> iteratorComponentChild in GetIteratorComponentInOrderCollection(iteratorComponentCurrent: iteratorComponentLeft))
                    {
                        yield return iteratorComponentChild;
                    }
                }

                yield return iteratorComponentCurrent;

                if (iteratorComponentCurrent.CheckNodeComponentRightIsNotNull(nodeComponentRight: out NodeComponent<Template1> iteratorComponentRight))
                {
                    foreach (NodeComponent<Template1> iteratorComponentChild in GetIteratorComponentInOrderCollection(iteratorComponentCurrent: iteratorComponentRight))
                    {
                        yield return iteratorComponentChild;
                    }
                }
            }

            if (IteratorComponentRoot is null)
            {
                yield break;
            }

            foreach (NodeComponent<Template1> iteratorComponentChild in GetIteratorComponentInOrderCollection(iteratorComponentCurrent: IteratorComponentRoot))
            {
                yield return iteratorComponentChild;
            }
        }

        public IEnumerable<NodeComponent<Template1>> GetIteratorComponentPostOrderCollection()
        {
            static IEnumerable<NodeComponent<Template1>> GetIteratorComponentPostOrderCollection(NodeComponent<Template1> iteratorComponentCurrent)
            {
                if (iteratorComponentCurrent is null)
                {
                    yield break;
                }

                if (iteratorComponentCurrent.CheckNodeComponentLeftIsNotNull(nodeComponentLeft: out NodeComponent<Template1> iteratorComponentLeft))
                {
                    foreach (NodeComponent<Template1> iteratorComponentChild in GetIteratorComponentPostOrderCollection(iteratorComponentCurrent: iteratorComponentLeft))
                    {
                        yield return iteratorComponentChild;
                    }
                }

                if (iteratorComponentCurrent.CheckNodeComponentRightIsNotNull(nodeComponentRight: out NodeComponent<Template1> iteratorComponentRight))
                {
                    foreach (NodeComponent<Template1> iteratorComponentChild in GetIteratorComponentPostOrderCollection(iteratorComponentCurrent: iteratorComponentRight))
                    {
                        yield return iteratorComponentChild;
                    }
                }

                yield return iteratorComponentCurrent;
            }

            if (IteratorComponentRoot is null)
            {
                yield break;
            }

            foreach (NodeComponent<Template1> iteratorComponentChild in GetIteratorComponentPostOrderCollection(iteratorComponentCurrent: IteratorComponentRoot))
            {
                yield return iteratorComponentChild;
            }
        }

        public override bool Equals(object uncastedIteratorComponent)
        {
            StringBuilder iteratorComponentStringBuilder = new();

            iteratorComponentStringBuilder.Append(value: $"[START]{nameof(IteratorComponent<Template1>)}[START]");
            iteratorComponentStringBuilder.AppendLine(value: string.Empty);
            iteratorComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(IteratorComponent<Template1>)}' class");
            iteratorComponentStringBuilder.AppendLine(value: string.Empty);
            iteratorComponentStringBuilder.Append(value: $"[END]{nameof(IteratorComponent<Template1>)}[END]");

            throw new NotImplementedException(message: iteratorComponentStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder iteratorComponentStringBuilder = new();

            iteratorComponentStringBuilder.Append(value: $"[START]{nameof(IteratorComponent<Template1>)}[START]");
            iteratorComponentStringBuilder.AppendLine(value: string.Empty);
            iteratorComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(IteratorComponent<Template1>)}' class");
            iteratorComponentStringBuilder.AppendLine(value: string.Empty);
            iteratorComponentStringBuilder.Append(value: $"[END]{nameof(IteratorComponent<Template1>)}[END]");

            throw new NotImplementedException(message: iteratorComponentStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder iteratorComponentStringBuilder = new();

            iteratorComponentStringBuilder.Append(value: $"[START]{nameof(IteratorComponent<Template1>)}[START]");
            iteratorComponentStringBuilder.AppendLine(value: string.Empty);
            iteratorComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(IteratorComponent<Template1>)}' class");
            iteratorComponentStringBuilder.AppendLine(value: string.Empty);
            iteratorComponentStringBuilder.Append(value: $"[END]{nameof(IteratorComponent<Template1>)}[END]");

            throw new NotImplementedException(message: iteratorComponentStringBuilder.ToString(), inner: new Exception());
        }
    }
}