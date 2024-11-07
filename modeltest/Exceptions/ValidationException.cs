namespace modeltest.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException()
           : base("One or more validation failures have occurred.")
        {
            this.Errors = new Dictionary<string, string[]>();
        }
        public ValidationException(IDictionary<string, string> failures) : this()

        {
            var failureGroups = failures
                .GroupBy(e => e.Key, e => e.Value);

            foreach (var failureGroup in failureGroups)
            {
                var propertyName = failureGroup.Key;
                var propertyFailures = failureGroup.ToArray();

                this.Errors.Add(propertyName, propertyFailures);
            }
        }

        public IDictionary<string, string[]> Errors { get; }
    }
}
