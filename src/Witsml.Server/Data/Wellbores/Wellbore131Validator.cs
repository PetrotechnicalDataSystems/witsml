﻿using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.DataAnnotations;
using Energistics.DataAccess.WITSML131;

namespace PDS.Witsml.Server.Data.Wellbores
{
    /// <summary>
    /// Provides validation for <see cref="Wellbore" /> data objects.
    /// </summary>
    /// <seealso cref="PDS.Witsml.Server.Data.DataObjectValidator{Energistics.DataAccess.WITSML131.Wellbore}" />
    [Export(typeof(IDataObjectValidator<Wellbore>))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class Wellbore131Validator : DataObjectValidator<Wellbore>
    {
        private readonly IWitsmlDataAdapter<Wellbore> _wellboreDataAdapter;
        private readonly IWitsmlDataAdapter<Well> _wellDataAdapter;

        /// <summary>
        /// Initializes a new instance of the <see cref="Wellbore131Validator"/> class.
        /// </summary>
        /// <param name="wellboreDataAdapter">The wellbore data adapter.</param>
        /// <param name="wellDataAdapter">The well data adapter.</param>
        [ImportingConstructor]
        public Wellbore131Validator(IWitsmlDataAdapter<Wellbore> wellboreDataAdapter, IWitsmlDataAdapter<Well> wellDataAdapter)
        {
            _wellboreDataAdapter = wellboreDataAdapter;
            _wellDataAdapter = wellDataAdapter;
        }

        /// <summary>
        /// Validates the data object while executing AddToStore.
        /// </summary>
        /// <returns>A collection of validation results.</returns>
        protected override IEnumerable<ValidationResult> ValidateForInsert()
        {
            // Validate parent uid property
            if (string.IsNullOrWhiteSpace(DataObject.UidWell))
            {
                yield return new ValidationResult(ErrorCodes.MissingParentUid.ToString(), new[] { "UidWell" });
            }

            // Validate parent exists
            else if (!_wellDataAdapter.Exists(new DataObjectId(DataObject.UidWell, DataObject.NameWell)))
            {
                yield return new ValidationResult(ErrorCodes.MissingParentDataObject.ToString(), new[] { "UidWell" });
            }

            // Validate UID does not exist
            else if (_wellboreDataAdapter.Exists(DataObject.GetObjectId()))
            {
                yield return new ValidationResult(ErrorCodes.DataObjectUidAlreadyExists.ToString(), new[] { "Uid" });
            }
        }
    }
}