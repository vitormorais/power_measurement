close all
clc
clear
t=-pi/10:0.0000120:pi/10;
signal = 230*sin(2*pi*10*t);
signal = awgn(signal,25,'measured'); % Add white Gaussian noise.


fc = 2;% Mudei para 100
F_amostragem = 8000;% Mudei para 100kHz/6
order =1;
[b,a] = butter(order,2*fc/F_amostragem,'low')
 
values(1) = signal(1);
for i=2:length(signal)
    
    values(i) = (b(1)*signal(i)+b(2)*signal(i-1)-a(2)*values(i-1))/a(1);
    
end

tmp = filter(b,a,signal);
figure;
plot(signal)
hold on
plot(tmp,'r')
plot(values+10,'k')
hold off