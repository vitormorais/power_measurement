#Power Measurement Development Repository

### Features

- Acquiring three-phase electrical measurements for powerflow calculation

### How to use

- Download the 2. Hardware PCB.zip file for further development with altium

### DEMO

[![c_sharp](https://i.imgur.com/11WRs3h.png "c_sharp")](https://i.imgur.com/11WRs3h.png "c_sharp")
[![board](https://i.imgur.com/ox0agaP.png "board")](https://i.imgur.com/ox0agaP.png "board")



------------



### Folder structure

| FOLDER   | DESCRIPTION  | comments  |
| :------------ | :------------ | :------------ |
|  1. DEV@bib XMC4700  |  development of the setup at library rooftop for PQ measurement |   |
|  2. Hardware PCB  |  development of PCB for 3PH measurment of voltages and currents  |   |
|  3. Software STM32  |  development of STM32 code for interaction of C# app   |   |
|  4. Software C#  |  development of C# code to display voltages and currents waveforms from STM32  |    relevant file:  ` \4. Software C#\C#_DEV\VI_MEAS\bin\Debug.VI_MEAS.exe `|    



### Folder structure (tree)

```bash
├── 1. DEV@bib XMC4700
│   ├── LICENSE.md
│   ├── MODBUS_RTU_MODE_XMC47
│   ├── README.md
│   ├── ensaios.xlsx
│   ├── evaluation.psimsch
│   ├── evaluation_rectifier.psimsch
│   ├── filter.m
│   ├── functions.h.docx
│   ├── rms_evaluation.slx
│   ├── rms_evaluation.smv
│   ├── rms_evaluation2.slx
│   ├── rms_evaluation_psim.psimsch
│   └── rms_evaluation_psim.smv
├── 2. Hardware PCB
│   ├── CAMtastic1.Cam
│   ├── CAMtastic2.Cam
│   ├── History
│   ├── Project Logs for vi_measurement
│   ├── Project Outputs for vi_measurement
│   ├── __Previews
│   ├── debug.log
│   ├── gerbers.zip
│   ├── malvega_pcb.PcbLib
│   ├── malvega_pcb.SchLib
│   ├── vi_measurement.PcbDoc
│   ├── vi_measurement.PcbLib
│   ├── vi_measurement.PrjPcb
│   ├── vi_measurement.PrjPcbStructure
│   ├── vi_measurement.SchDoc
│   └── vi_measurement.SchLib
├── 2. Hardware PCB.zip
├── 3. Software STM32
│   ├── drivers
│   ├── en.flasher-stm32.zip
│   ├── generic_boot20_pc13.bin
│   └── stm32_dev
├── 4. Software C#
│   └── C#_DEV
├── README.md
├── SerialProtocol.xlsx
├── folder_structure_binary.txt
├── tree.txt
└── z. junk
    ├── C_sharp_demo.jpg
    └── board.png
```