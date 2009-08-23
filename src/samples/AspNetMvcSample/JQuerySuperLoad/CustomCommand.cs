namespace JQuerySuperLoad
{
	public class CustomCommand: SuperLoadCommand
	{
		public CustomCommand(string commandVerb)
		{
			_commandVerb = commandVerb;
		}

		private readonly string _commandVerb;

		protected override string CommandVerb
		{
			get { return _commandVerb; }
		}
	}
}