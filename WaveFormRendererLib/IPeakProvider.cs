using CSCore;

namespace NAudio.WaveFormRenderer
{
    public interface IPeakProvider
    {
        void Init(ISampleSource reader, int samplesPerPixel);
        PeakInfo GetNextPeak();
    }
}