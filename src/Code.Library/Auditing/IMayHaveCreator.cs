﻿using System;

namespace Code.Library.Auditing
{
    public interface IMayHaveCreator<TCreator>
    {
        /// <summary>
        /// Reference to the creator.
        /// </summary>
        //[CanBeNull]
        TCreator Creator { get; set; }
    }

    /// <summary>
    /// Standard interface for an entity that MAY have a creator.
    /// </summary>
    public interface IMayHaveCreator
    {
        /// <summary>
        /// Id of the creator.
        /// </summary>
        Guid? CreatorId { get; set; }
    }
}