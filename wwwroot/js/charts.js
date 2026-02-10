window.renderAreaChart = (elementId) => {
    const el = document.querySelector("#" + elementId);
    if (el) el.innerHTML = "";
    var options = {
        series: [{
            name: 'Net Satış',
            data: [31000, 40000, 28000, 51000, 42000, 109000, 100000]
        }, {
            name: 'Brüt Satış',
            data: [11000, 32000, 45000, 32000, 34000, 52000, 41000]
        }],
        chart: {
            height: 350,
            type: 'area',
            toolbar: { show: false },
            fontFamily: 'Inter, sans-serif'
        },
        dataLabels: {
            enabled: false
        },
        stroke: {
            curve: 'smooth'
        },
        colors: ['#0077b6', '#48cae4'],
        xaxis: {
            type: 'datetime',
            categories: ["2018-09-19T00:00:00.000Z", "2018-09-19T01:30:00.000Z", "2018-09-19T02:30:00.000Z", "2018-09-19T03:30:00.000Z", "2018-09-19T04:30:00.000Z", "2018-09-19T05:30:00.000Z", "2018-09-19T06:30:00.000Z"]
        },
        tooltip: {
            x: {
                format: 'dd/MM/yy HH:mm'
            },
        },
    };

    var chart = new ApexCharts(document.querySelector("#" + elementId), options);
    chart.render();
};

window.renderDonutChart = (elementId) => {
    const el = document.querySelector("#" + elementId);
    if (el) el.innerHTML = "";
    var options = {
        series: [44, 55, 41, 17, 15],
        chart: {
            type: 'donut',
            height: 350,
            fontFamily: 'Inter, sans-serif'
        },
        labels: ['Kurumsal', 'Bireysel', 'Kamu', 'STK', 'Diğer'],
        colors: ['#0077b6', '#0096c7', '#00b4d8', '#48cae4', '#90e0ef'],
        plotOptions: {
            pie: {
                donut: {
                    size: '70%'
                }
            }
        },
        legend: {
            position: 'bottom'
        }
    };

    var chart = new ApexCharts(document.querySelector("#" + elementId), options);
    chart.render();
};

window.renderBarChart = (elementId) => {
    const el = document.querySelector("#" + elementId);
    if (el) el.innerHTML = "";
    var options = {
        series: [{
            data: [400, 430, 448, 470, 540, 580, 690, 1100, 1200, 1380]
        }],
        chart: {
            type: 'bar',
            height: 350,
            toolbar: { show: false },
            fontFamily: 'Inter, sans-serif'
        },
        plotOptions: {
            bar: {
                borderRadius: 4,
                horizontal: true,
            }
        },
        dataLabels: {
            enabled: false
        },
        colors: ['#0077b6'],
        xaxis: {
            categories: ['İstanbul', 'Ankara', 'İzmir', 'Bursa', 'Antalya', 'Adana', 'Konya', 'Gaziantep', 'Mersin', 'Kayseri'],
        }
    };

    var chart = new ApexCharts(document.querySelector("#" + elementId), options);
    chart.render();
};

window.renderRadialChart = (elementId) => {
    const el = document.querySelector("#" + elementId);
    if (el) el.innerHTML = "";
    var options = {
        series: [76],
        chart: {
            type: 'radialBar',
            offsetY: -20,
            sparkline: {
                enabled: true
            },
            fontFamily: 'Inter, sans-serif'
        },
        plotOptions: {
            radialBar: {
                startAngle: -90,
                endAngle: 90,
                track: {
                    background: "#e7e7e7",
                    strokeWidth: '97%',
                    margin: 5, // margin is in pixels
                    dropShadow: {
                        enabled: true,
                        top: 2,
                        left: 0,
                        color: '#999',
                        opacity: 1,
                        blur: 2
                    }
                },
                dataLabels: {
                    name: {
                        show: false
                    },
                    value: {
                        offsetY: -2,
                        fontSize: '22px'
                    }
                }
            }
        },
        grid: {
            padding: {
                top: -10
            }
        },
        fill: {
            type: 'gradient',
            gradient: {
                shade: 'light',
                shadeIntensity: 0.4,
                inverseColors: false,
                opacityFrom: 1,
                opacityTo: 1,
                stops: [0, 50, 53, 91]
            },
        },
        labels: ['Ortalama Memnuniyet'],
        colors: ['#00b4d8']
    };

    var chart = new ApexCharts(document.querySelector("#" + elementId), options);
    chart.render();
};
