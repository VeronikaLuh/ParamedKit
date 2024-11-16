const Collapsible = ({toggle, children}) => {
  return (
    <div>
      {toggle && (
        <div>
          {children}
        </div>
      )}
    </div>
  );
};

export default Collapsible;