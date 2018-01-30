
/*
*********************************************************************************************************
*                                             DEFENITION FILE
*********************************************************************************************************
*/


#define TICKS_PER_SECOND (1000u)       //For the micrium oscilloscope
#define ADC_CONVERT 0.00080566f         //Transforming ADC Data to Ampere equation result. (((ADCread*3.3)/4095)
#define OFFSETADC 1.65f					//ADC offset value
#define GAINADC 100.0f
#define DIV_SQ2_SQ3 0.81649658f         //sqrt(2)/sqrt(3)
#define DIV_1_SQ6 0.40824829f           //1/sqrt(6)
#define DIV_1_SQ2 0.70710678f           //1/sqrt(2)


/*
--------------------------------------------------------------------------------------------------------
					 Change the variables about the motor and FFT here
--------------------------------------------------------------------------------------------------------
*/


/*Sample size and FFT size*/
#define FFTSIZE 2048u

/*Half of the sample size and FFT size*/
#define HFFTSIZE 1024u

/*Sampling frequency it also necessary to change on the PWM APP*/
#define SAMPLINGFREQ 1000u

/*Motor supply frequency*/
#define MOTORSFREQ  50u

/*Bin grouping number, in order to accurately obtain the desired value, it is necessary to
group bins for example we say the 50 hz frequency bin is the 49.7 hz bin + 51.4hz bin */
#define BINGROUP 0u

/*Short-Circuit defined limit for fault alarm */
#define SCLIMIT 0.00000001f

/*Broken Rotor Bar defined limit for fault alarm */
#define BRBLIMIT 0.00000001f

/*EPVA FFT magnitude average  defined limit*/
#define FFTEPVALIMIT 0.0000001f

/*Broken Rotor Bar frequency, right now it should be defined here but the optimal way is to calculate it
 using fs(1+2s) where s is the slip*/
#define FREQBRB 55
