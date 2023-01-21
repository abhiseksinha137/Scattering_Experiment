
from seabreeze.spectrometers import Spectrometer, list_devices
from matplotlib import pyplot  as plt
import numpy as np
import pandas as pd
import time
import sys

if len(sys.argv)>1:
    savePath=sys.argv[1]
else:
    savePath='data.csv'

devices = list_devices()

spec = Spectrometer(devices[0])
ms=1000
spec.integration_time_micros(300*ms) # us
average=10;

wavelengths = spec.wavelengths()
intensities=np.zeros(len(wavelengths))
for i in range(average):
    intensities = intensities+spec.intensities()
spec.close()

intensities=intensities/average;
intensities[wavelengths<510]=[0]  # Remove the garbage from the start

writeData={'Lambda': wavelengths, 'Intensity': intensities};
df=pd.DataFrame(writeData);
df.to_csv(savePath, index=False)
# plt.plot(wavelengths,intensities)
# plt.show()

