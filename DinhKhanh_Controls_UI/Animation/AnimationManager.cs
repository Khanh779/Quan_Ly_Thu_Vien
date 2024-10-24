using DinhKhanh_Controls_UI.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DinhKhanh_Controls_UI.Animation
{
    public partial class AnimationManager
    {
        List<double> an = new List<double>();
        readonly System.Windows.Forms.Timer _timer = new Timer() { Interval = 5, Enabled = false };
        List<Point> animationSources = new List<Point>();
        double MIN_VALUE = 0.0;
        double MAX_VALUE = 1.0;
        public double Increment { get; set; } = 0.08;
        List<AnimationType> ATs = new List<AnimationType>();

        public bool Singular { get { return sing; } set { sing = value; } }

        public AnimationManager(bool singular = true)
        {
            an = new List<double>();
            animationSources = new List<Point>();
            ATs = new List<AnimationType>();
            sing = singular;
            _timer.Tick += _timer_Tick;
            _timer.Stop();

        }

        private void UpdateProgress()
        {
            for (int i = 0; i < an.Count; i++)
            {
                an[i] += (ATs[i] == AnimationType.In) ? Increment : -Increment;

                if (ATs[i] == AnimationType.In && an[i] >= MAX_VALUE)
                {
                    an[i] = MAX_VALUE;
                    RemoveAnimation(i);
                }
                else if (ATs[i] == AnimationType.Out && an[i] <= MIN_VALUE)
                {
                    an[i] = MIN_VALUE;
                    RemoveAnimation(i);
                }
            }
        }



        private void RemoveAnimation(int index)
        {
            if (!sing)
            {
                an.RemoveAt(index);
                animationSources.RemoveAt(index);
                ATs.RemoveAt(index);
                if (an.Count <= 0)
                {
                    an.Clear(); animationSources.Clear();
                    _timer.Dispose();
                    _timer.Stop();

                    Complete?.Invoke();
                }
            }
            else
            {
                if ((ATs[index] == AnimationType.Out && an[index] <= MIN_VALUE) ||
                 (ATs[index] == AnimationType.In && an[index] >= MAX_VALUE))
                {
                    _timer.Dispose();
                    _timer.Stop();

                    Complete?.Invoke();
                }
            }
        }

        public void StopAll()
        {
            _timer.Stop(); Complete?.Invoke();
            _timer?.Dispose();

        }



        private void _timer_Tick(object sender, EventArgs e)
        {
            UpdateProgress();
            AnimationProgress?.Invoke(null);
        }

        public double GetProgress(int index)
        {
            if (an.Count <= 0)
            {
                return 0;
            }
            else
            {
                return an[index];
            }
        }

        public double GetProgress()
        {
            return GetProgress(0);
        }



        public int GetAnimationCount()
        {
            return an.Count;
        }

        public delegate void OnAnimateProgress(object obj);
        public delegate void AnimationCompleted();

        public event AnimationCompleted Complete;

        public event OnAnimateProgress AnimationProgress;

        bool sing = false;

        public bool IsAnimating()
        {
            return _timer.Enabled;
        }

        public Point GetSource(int i)
        {
            return animationSources[i];
        }

        public Point GetSource()
        {
            return animationSources[0];
        }

        public void StartNewAnimation(AnimationType animationType)
        {
            StartNewAnimation(animationType, new Point(0, 0));
        }

        public void StartNewAnimation(AnimationType animationType, Point point)
        {
            _timer.Dispose();
            var isFirstAnimation = !IsAnimating() && an.Count == 0;
            if (isFirstAnimation || !sing)
            {
                ATs.Add(animationType);
                an.Add(animationType == AnimationType.In ? MIN_VALUE : MAX_VALUE);
                animationSources.Add(point);
                //if (isFirstAnimation)
                //    ATs[0] = animationType;
            }
            else
            {
                ATs[0] = animationType;
                an[0] = animationType == AnimationType.In ? MIN_VALUE : MAX_VALUE;
                animationSources[0] = point;
            }
            if (!IsAnimating())
                _timer.Start();
        }

        public void ContinueCurrentAnimation(AnimationType animationType, int index = 0)
        {
            if (index < an.Count)
            {
                ATs[index] = animationType;
                an[index] = animationType == AnimationType.In ? MIN_VALUE : MAX_VALUE;
                if (!IsAnimating())
                    _timer.Start();
            }
        }


        //public void StartNewAnimation(AnimationType animationType, Point point)
        //{
        //    if (animationType == AnimationType.InOut)
        //    {
        //        ATs.Add(AnimationType.In);
        //        an.Add(MIN_VALUE);
        //        animationSources.Add(point);
        //    }
        //    else if (animationType == AnimationType.OutIn)
        //    {
        //        ATs.Add(AnimationType.Out);
        //        an.Add(MAX_VALUE);
        //        animationSources.Add(point);
        //    }
        //    else
        //    {

        //        if (!IsAnimating() || !sing)
        //        {
        //            ATs.Add(animationType);
        //            an.Add(animationType == AnimationType.In ? MIN_VALUE : MAX_VALUE);
        //            animationSources.Add(point);
        //        }
        //        else
        //        {
        //            ATs[0] = animationType;
        //            an[0] = animationType == AnimationType.In ? MIN_VALUE : MAX_VALUE;
        //            animationSources[0] = point;
        //        }
        //    }

        //    if (!IsAnimating()) _timer.Start();
        //}

    }
}
