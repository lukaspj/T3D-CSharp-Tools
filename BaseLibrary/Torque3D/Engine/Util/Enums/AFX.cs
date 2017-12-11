namespace Torque3D.Util
{
   public enum afxTargeting
    {
        Off,
        Standard,
        Free
   }

    public enum afxTargetCheck
    {
        Poll,
        On_Mouse_Move
    }

    public enum afxBillboard_BlendStyle
    {
        Normal,
        Additive,
        Subtractive,
        PremultAlpha
    }

    public enum afxParticleEmitterPath_OriginType
    {
        Origin,
        Point,
        Vector,
        Tangent
    }

    public enum afxBillboard_TexFuncType
    {
        Replace,
        Modulate,
        Add
    }

    public enum afxParticlePool_PoolType
    {
        Normal,
        TwoPass
    }

    public enum afxPhraseEffect_MatchType
    {
        Any,
        All
    }

    public enum afxPhraseEffect_StateType
    {
        On,
        Off,
        Both
    }

    public enum afxPhraseEffect_PhraseType
    {
        Triggered,
        Continuous
    }

    public enum afxPlayerMovement_OpType
    {
        Add,
        Multiply,
        Replace
    }

    public enum afxProjectile_LaunchDirType
    {
        TowardPos2Constraint,
        OrientConstraint,
        LaunchDirField
    }

    public enum afxRPGMagicSpell_TargetType
    {
        Nothing,
        Self,
        Friend,
        Enemy,
        Corpse,
        Free
    }

    public enum afxXM_BoxConformType
    {
        X_POS, X_NEG, Y_POS, Y_NEG, Z_POS, Z_NEG
    }

    public enum afxXM_WaveFormType
    {
        None,
        Sine,
        Square,
        Triangle,
        Sawtooth,
        Noise,
        One
    }

    public enum afxXM_WaveOpType
    {
        Add,
        Multiply,
        Replace
    }

    public enum afxZodiac_BlendType
    {
        Normal,
        Additive,
        Subtractive
    }

    public enum afxZodiacPlane_BlendType
    {
        Normal,
        Additive,
        Subtractive
    }

    public enum afxZodiacPlane_FacingType
    {
        Up,
        Down,
        Forward,
        Backward,
        Right,
        Left
    }
}
