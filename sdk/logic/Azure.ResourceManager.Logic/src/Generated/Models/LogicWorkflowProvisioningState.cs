// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The workflow provisioning state. </summary>
    public readonly partial struct LogicWorkflowProvisioningState : IEquatable<LogicWorkflowProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LogicWorkflowProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string AcceptedValue = "Accepted";
        private const string RunningValue = "Running";
        private const string ReadyValue = "Ready";
        private const string CreatingValue = "Creating";
        private const string CreatedValue = "Created";
        private const string DeletingValue = "Deleting";
        private const string DeletedValue = "Deleted";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";
        private const string MovingValue = "Moving";
        private const string UpdatingValue = "Updating";
        private const string RegisteringValue = "Registering";
        private const string RegisteredValue = "Registered";
        private const string UnregisteringValue = "Unregistering";
        private const string UnregisteredValue = "Unregistered";
        private const string CompletedValue = "Completed";
        private const string RenewingValue = "Renewing";
        private const string PendingValue = "Pending";
        private const string WaitingValue = "Waiting";
        private const string InProgressValue = "InProgress";

        /// <summary> NotSpecified. </summary>
        public static LogicWorkflowProvisioningState NotSpecified { get; } = new LogicWorkflowProvisioningState(NotSpecifiedValue);
        /// <summary> Accepted. </summary>
        public static LogicWorkflowProvisioningState Accepted { get; } = new LogicWorkflowProvisioningState(AcceptedValue);
        /// <summary> Running. </summary>
        public static LogicWorkflowProvisioningState Running { get; } = new LogicWorkflowProvisioningState(RunningValue);
        /// <summary> Ready. </summary>
        public static LogicWorkflowProvisioningState Ready { get; } = new LogicWorkflowProvisioningState(ReadyValue);
        /// <summary> Creating. </summary>
        public static LogicWorkflowProvisioningState Creating { get; } = new LogicWorkflowProvisioningState(CreatingValue);
        /// <summary> Created. </summary>
        public static LogicWorkflowProvisioningState Created { get; } = new LogicWorkflowProvisioningState(CreatedValue);
        /// <summary> Deleting. </summary>
        public static LogicWorkflowProvisioningState Deleting { get; } = new LogicWorkflowProvisioningState(DeletingValue);
        /// <summary> Deleted. </summary>
        public static LogicWorkflowProvisioningState Deleted { get; } = new LogicWorkflowProvisioningState(DeletedValue);
        /// <summary> Canceled. </summary>
        public static LogicWorkflowProvisioningState Canceled { get; } = new LogicWorkflowProvisioningState(CanceledValue);
        /// <summary> Failed. </summary>
        public static LogicWorkflowProvisioningState Failed { get; } = new LogicWorkflowProvisioningState(FailedValue);
        /// <summary> Succeeded. </summary>
        public static LogicWorkflowProvisioningState Succeeded { get; } = new LogicWorkflowProvisioningState(SucceededValue);
        /// <summary> Moving. </summary>
        public static LogicWorkflowProvisioningState Moving { get; } = new LogicWorkflowProvisioningState(MovingValue);
        /// <summary> Updating. </summary>
        public static LogicWorkflowProvisioningState Updating { get; } = new LogicWorkflowProvisioningState(UpdatingValue);
        /// <summary> Registering. </summary>
        public static LogicWorkflowProvisioningState Registering { get; } = new LogicWorkflowProvisioningState(RegisteringValue);
        /// <summary> Registered. </summary>
        public static LogicWorkflowProvisioningState Registered { get; } = new LogicWorkflowProvisioningState(RegisteredValue);
        /// <summary> Unregistering. </summary>
        public static LogicWorkflowProvisioningState Unregistering { get; } = new LogicWorkflowProvisioningState(UnregisteringValue);
        /// <summary> Unregistered. </summary>
        public static LogicWorkflowProvisioningState Unregistered { get; } = new LogicWorkflowProvisioningState(UnregisteredValue);
        /// <summary> Completed. </summary>
        public static LogicWorkflowProvisioningState Completed { get; } = new LogicWorkflowProvisioningState(CompletedValue);
        /// <summary> Renewing. </summary>
        public static LogicWorkflowProvisioningState Renewing { get; } = new LogicWorkflowProvisioningState(RenewingValue);
        /// <summary> Pending. </summary>
        public static LogicWorkflowProvisioningState Pending { get; } = new LogicWorkflowProvisioningState(PendingValue);
        /// <summary> Waiting. </summary>
        public static LogicWorkflowProvisioningState Waiting { get; } = new LogicWorkflowProvisioningState(WaitingValue);
        /// <summary> InProgress. </summary>
        public static LogicWorkflowProvisioningState InProgress { get; } = new LogicWorkflowProvisioningState(InProgressValue);
        /// <summary> Determines if two <see cref="LogicWorkflowProvisioningState"/> values are the same. </summary>
        public static bool operator ==(LogicWorkflowProvisioningState left, LogicWorkflowProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LogicWorkflowProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(LogicWorkflowProvisioningState left, LogicWorkflowProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="LogicWorkflowProvisioningState"/>. </summary>
        public static implicit operator LogicWorkflowProvisioningState(string value) => new LogicWorkflowProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LogicWorkflowProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LogicWorkflowProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
