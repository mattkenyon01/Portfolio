window.renderChart = function (chartId, value1) {
    const el = document.getElementById(chartId);
    if (!el || !window.Chart) return;

    const ctx = el.getContext('2d');

    // Ensure value1 stays between 0–100
    const percent = Math.max(0, Math.min(100, value1));
    const remainder = 100 - percent;

    // Destroy previous chart if it exists
    if (el._chartInstance) {
        el._chartInstance.destroy();
    }

    el._chartInstance = new Chart(ctx, {
        type: 'doughnut',
        data: {
            labels: ['Completed', 'Remaining'],
            datasets: [{
                data: [percent, remainder],
                backgroundColor: ['#e7571d', 'transparent'],

                borderWidth: 0
            }]
        },
        options: {
            cutout: '70%', // inner hole size
            plugins: { legend: { display: false } },
            animation: { duration: 700 },
            maintainAspectRatio: false
        }
    });
};
