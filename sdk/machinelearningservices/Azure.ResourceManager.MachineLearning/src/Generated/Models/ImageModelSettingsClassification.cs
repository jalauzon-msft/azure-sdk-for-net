// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Settings used for training the model.
    /// For more information on the available settings please visit the official documentation:
    /// https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
    /// </summary>
    public partial class ImageModelSettingsClassification : ImageModelSettings
    {
        /// <summary> Initializes a new instance of <see cref="ImageModelSettingsClassification"/>. </summary>
        public ImageModelSettingsClassification()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ImageModelSettingsClassification"/>. </summary>
        /// <param name="amsGradient"> Enable AMSGrad when optimizer is 'adam' or 'adamw'. </param>
        /// <param name="advancedSettings"> Settings for advanced scenarios. </param>
        /// <param name="augmentations"> Settings for using Augmentations. </param>
        /// <param name="beta1"> Value of 'beta1' when optimizer is 'adam' or 'adamw'. Must be a float in the range [0, 1]. </param>
        /// <param name="beta2"> Value of 'beta2' when optimizer is 'adam' or 'adamw'. Must be a float in the range [0, 1]. </param>
        /// <param name="checkpointFrequency"> Frequency to store model checkpoints. Must be a positive integer. </param>
        /// <param name="checkpointRunId"> The id of a previous run that has a pretrained checkpoint for incremental training. </param>
        /// <param name="checkpointModel"> The pretrained checkpoint model for incremental training. </param>
        /// <param name="distributed"> Whether to use distributed training. </param>
        /// <param name="earlyStopping"> Enable early stopping logic during training. </param>
        /// <param name="earlyStoppingDelay">
        /// Minimum number of epochs or validation evaluations to wait before primary metric improvement
        /// is tracked for early stopping. Must be a positive integer.
        /// </param>
        /// <param name="earlyStoppingPatience">
        /// Minimum number of epochs or validation evaluations with no primary metric improvement before
        /// the run is stopped. Must be a positive integer.
        /// </param>
        /// <param name="evaluationFrequency"> Frequency to evaluate validation dataset to get metric scores. Must be a positive integer. </param>
        /// <param name="enableOnnxNormalization"> Enable normalization when exporting ONNX model. </param>
        /// <param name="gradientAccumulationStep">
        /// Gradient accumulation means running a configured number of "GradAccumulationStep" steps without
        /// updating the model weights while accumulating the gradients of those steps, and then using
        /// the accumulated gradients to compute the weight updates. Must be a positive integer.
        /// </param>
        /// <param name="layersToFreeze">
        /// Number of layers to freeze for the model. Must be a positive integer.
        /// For instance, passing 2 as value for 'seresnext' means
        /// freezing layer0 and layer1. For a full list of models supported and details on layer freeze, please
        /// see: https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
        /// </param>
        /// <param name="learningRate"> Initial learning rate. Must be a float in the range [0, 1]. </param>
        /// <param name="learningRateScheduler"> Type of learning rate scheduler. Must be 'warmup_cosine' or 'step'. </param>
        /// <param name="modelName">
        /// Name of the model to use for training.
        /// For more information on the available models please visit the official documentation:
        /// https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
        /// </param>
        /// <param name="momentum"> Value of momentum when optimizer is 'sgd'. Must be a float in the range [0, 1]. </param>
        /// <param name="nesterov"> Enable nesterov when optimizer is 'sgd'. </param>
        /// <param name="numberOfEpochs"> Number of training epochs. Must be a positive integer. </param>
        /// <param name="numberOfWorkers"> Number of data loader workers. Must be a non-negative integer. </param>
        /// <param name="optimizer"> Type of optimizer. </param>
        /// <param name="randomSeed"> Random seed to be used when using deterministic training. </param>
        /// <param name="stepLRGamma"> Value of gamma when learning rate scheduler is 'step'. Must be a float in the range [0, 1]. </param>
        /// <param name="stepLRStepSize"> Value of step size when learning rate scheduler is 'step'. Must be a positive integer. </param>
        /// <param name="trainingBatchSize"> Training batch size. Must be a positive integer. </param>
        /// <param name="validationBatchSize"> Validation batch size. Must be a positive integer. </param>
        /// <param name="warmupCosineLRCycles"> Value of cosine cycle when learning rate scheduler is 'warmup_cosine'. Must be a float in the range [0, 1]. </param>
        /// <param name="warmupCosineLRWarmupEpochs"> Value of warmup epochs when learning rate scheduler is 'warmup_cosine'. Must be a positive integer. </param>
        /// <param name="weightDecay"> Value of weight decay when optimizer is 'sgd', 'adam', or 'adamw'. Must be a float in the range[0, 1]. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="trainingCropSize"> Image crop size that is input to the neural network for the training dataset. Must be a positive integer. </param>
        /// <param name="validationCropSize"> Image crop size that is input to the neural network for the validation dataset. Must be a positive integer. </param>
        /// <param name="validationResizeSize"> Image size to which to resize before cropping for validation dataset. Must be a positive integer. </param>
        /// <param name="weightedLoss">
        /// Weighted loss. The accepted values are 0 for no weighted loss.
        /// 1 for weighted loss with sqrt.(class_weights). 2 for weighted loss with class_weights. Must be 0 or 1 or 2.
        /// </param>
        internal ImageModelSettingsClassification(bool? amsGradient, string advancedSettings, string augmentations, float? beta1, float? beta2, int? checkpointFrequency, string checkpointRunId, MachineLearningFlowModelJobInput checkpointModel, bool? distributed, bool? earlyStopping, int? earlyStoppingDelay, int? earlyStoppingPatience, int? evaluationFrequency, bool? enableOnnxNormalization, int? gradientAccumulationStep, int? layersToFreeze, float? learningRate, LearningRateScheduler? learningRateScheduler, string modelName, float? momentum, bool? nesterov, int? numberOfEpochs, int? numberOfWorkers, StochasticOptimizer? optimizer, int? randomSeed, float? stepLRGamma, int? stepLRStepSize, int? trainingBatchSize, int? validationBatchSize, float? warmupCosineLRCycles, int? warmupCosineLRWarmupEpochs, float? weightDecay, IDictionary<string, BinaryData> serializedAdditionalRawData, int? trainingCropSize, int? validationCropSize, int? validationResizeSize, int? weightedLoss) : base(amsGradient, advancedSettings, augmentations, beta1, beta2, checkpointFrequency, checkpointRunId, checkpointModel, distributed, earlyStopping, earlyStoppingDelay, earlyStoppingPatience, evaluationFrequency, enableOnnxNormalization, gradientAccumulationStep, layersToFreeze, learningRate, learningRateScheduler, modelName, momentum, nesterov, numberOfEpochs, numberOfWorkers, optimizer, randomSeed, stepLRGamma, stepLRStepSize, trainingBatchSize, validationBatchSize, warmupCosineLRCycles, warmupCosineLRWarmupEpochs, weightDecay, serializedAdditionalRawData)
        {
            TrainingCropSize = trainingCropSize;
            ValidationCropSize = validationCropSize;
            ValidationResizeSize = validationResizeSize;
            WeightedLoss = weightedLoss;
        }

        /// <summary> Image crop size that is input to the neural network for the training dataset. Must be a positive integer. </summary>
        [WirePath("trainingCropSize")]
        public int? TrainingCropSize { get; set; }
        /// <summary> Image crop size that is input to the neural network for the validation dataset. Must be a positive integer. </summary>
        [WirePath("validationCropSize")]
        public int? ValidationCropSize { get; set; }
        /// <summary> Image size to which to resize before cropping for validation dataset. Must be a positive integer. </summary>
        [WirePath("validationResizeSize")]
        public int? ValidationResizeSize { get; set; }
        /// <summary>
        /// Weighted loss. The accepted values are 0 for no weighted loss.
        /// 1 for weighted loss with sqrt.(class_weights). 2 for weighted loss with class_weights. Must be 0 or 1 or 2.
        /// </summary>
        [WirePath("weightedLoss")]
        public int? WeightedLoss { get; set; }
    }
}
