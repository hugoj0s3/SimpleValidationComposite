﻿using System;

namespace SimpleCompositeValidation.Validations
{
	/// <summary>
	/// Validates a condition that must not be true to keep validation valid.
	/// </summary>
	/// <typeparam name="T">Type of the Target that will be validated</typeparam>
	public class MustNotValidation<T> : MustValidation<T> 
    {

	    /// <summary>
	    /// Creates a validation with given parameters.
	    /// </summary>
	    /// <param name="groupName">Group name to group your validations, it can be a property name for example</param>
	    /// <param name="rule">Condition</param>
	    public MustNotValidation(
		    string groupName,
		    Func<T, bool> rule)
		    : base(groupName, x => !rule.Invoke(x), default(T))
	    {

	    }

		/// <summary>
		/// Creates a validation with given parameters.
		/// </summary>
		/// <param name="groupName">Group name to group your validations, it can be a property name for example</param>
		/// <param name="rule">Condition</param>
		/// <param name="target">Target to be validated</param>
		public MustNotValidation(
            string groupName,
            Func<T, bool> rule,
            T target)
            : base(groupName, x => !rule.Invoke(x), target)
        {

        }

        /// <summary>
        /// Creates a validation with given parameters.
        /// </summary>
        /// <param name="groupName">Group name to group your validations, it can be a property name for example</param>
        /// <param name="formatMessageult formatMessage to be applied in the failures</param>
        /// <param name="target">Target to be validated</param>
        /// <param name="rule">Condition</param>
        /// <param name="severity">Severity in case of failure</param>
        public MustNotValidation(
            string groupName,
            Func<T, bool> rule,
            string formatMessage = null,
            int severity = 1,
            T target = default(T))
            : base(groupName, x => !rule.Invoke(x), formatMessage, severity, target)
        {

        }

    }
}
