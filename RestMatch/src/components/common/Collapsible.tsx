import {ReactNode} from "react";


interface CollapsibleProps {
  toggle: boolean;
  children: ReactNode;
}

const Collapsible = ({ toggle, children }: CollapsibleProps) => {
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