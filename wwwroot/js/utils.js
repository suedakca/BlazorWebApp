window.downloadFile = (fileName, contentType, content) => {
    // Create a blob from the content
    const blob = new Blob([content], { type: contentType });
    
    // Create a link element
    const url = URL.createObjectURL(blob);
    const a = document.createElement('a');
    
    // Set link properties
    a.href = url;
    a.download = fileName;
    
    // Programmatically click the link to trigger download
    document.body.appendChild(a);
    a.click();
    
    // Cleanup
    document.body.removeChild(a);
    URL.revokeObjectURL(url);
};

window.printPage = () => {
    window.print();
};
