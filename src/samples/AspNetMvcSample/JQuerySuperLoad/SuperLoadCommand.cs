namespace JQuerySuperLoad
{
	public abstract class SuperLoadCommand
	{
		public string CommandText { get { return "!" + CommandVerb; } }
		protected abstract string CommandVerb { get; }

		public static readonly UpdateCommand Update = new UpdateCommand();
		public static readonly PrependCommand Prepend = new PrependCommand();
		public static readonly AppendCommand Append = new AppendCommand();

		public static CustomCommand Custom(string commandVerb)
		{
			return new CustomCommand(commandVerb);
		}
	}
}